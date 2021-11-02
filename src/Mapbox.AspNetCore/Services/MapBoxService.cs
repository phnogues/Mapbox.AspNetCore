using Mapbox.AspNetCore.Helpers;
using Mapbox.AspNetCore.Interfaces;
using Mapbox.AspNetCore.Models;
using System;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;

namespace Mapbox.AspNetCore.Services
{
    public class MapBoxService : IMapboxService
    {
        private readonly IMapboxKeyService mapboxKeyService;
        private readonly HttpClient httpClient;

        public MapBoxService(HttpClient httpClient, IMapboxKeyService mapboxKeyService)
        {
            this.mapboxKeyService = mapboxKeyService;
            this.httpClient = httpClient;
        }

        public async Task<MapboxResult> GeocodingAsync(GeocodingParameters parameters)
        {
            string apiKey = mapboxKeyService.ApiKey();

            if (string.IsNullOrEmpty(parameters.Query))
            {
                throw new ArgumentException("Query is required");
            }

            string urlQuery = Constants.URL_GEOCODING_API + "mapbox.places/";

            urlQuery += $"{HttpUtility.UrlEncode(parameters.Query)}.json";
            urlQuery += $"?limit={parameters.Limit}";

            if (!string.IsNullOrEmpty(parameters.CountryCode))
            {
                urlQuery += $"&country={parameters.CountryCode}";
            }

            if (parameters.Proximity != null && parameters.Proximity.Latitude != 0d && parameters.Proximity.Longitude != 0d)
            {
                string latitude = parameters.Proximity.Latitude.ToString("0.000", CultureInfo.InvariantCulture);
                string longitude = parameters.Proximity.Longitude.ToString("0.000", CultureInfo.InvariantCulture);

                urlQuery += $"&proximity={longitude}%2C{latitude}";
            }

            urlQuery += $"&access_token={apiKey}";

            var request = new HttpRequestMessage(HttpMethod.Get, urlQuery);
            request.Headers.Add("Accept", "application/vnd.github.v3+json");

            var response = await this.httpClient.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var apiResults = await JsonSerializer.DeserializeAsync<MapboxApiResult>(responseStream);

                if (parameters.MinRelevance != 0d)
                {
                    apiResults.features = apiResults.features.Where(f => f.relevance >= parameters.MinRelevance).ToList();
                }

                return apiResults.ConvertResults();
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
    }
}
