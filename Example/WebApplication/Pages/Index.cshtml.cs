using Mapbox.AspNetCore.Interfaces;
using Mapbox.AspNetCore.Models;
using Mapbox.AspNetCore.Models.Proximity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace WebApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IMapboxService _mapboxService;

        public IndexModel(ILogger<IndexModel> logger, IMapboxService mapboxService)
        {
            _logger = logger;
            _mapboxService = mapboxService;
        }

        public MapboxResults GeocondingResults { get; set; }
        public MapboxResult ReverseGeocondingResult { get; set; }

        public string Query { get; set; } = "Avenue Anatole France, Paris";
        public string CountryCode { get; set; } = "FR";
        public double MinRelevance { get; set; } = 0.6;

        public GeoCoordinate Coordinates { get; set; } = new GeoCoordinate(48.858256895096574, 2.2943737309434593);

        public async Task OnGet()
        {
            var parameters = new GeocodingParameters()
            {
                Query = this.Query,
                CountryCode = this.CountryCode,
                Proximity = new ProximityIp(),
                Limit = 100,
                MinRelevance = this.MinRelevance,
                AutoComplete = false
            };

            GeocondingResults = await _mapboxService.GeocodingAsync(parameters);

            var reverseParameters = new ReverseGeocodingParameters()
            {
                Coordinates = Coordinates,
            };

            ReverseGeocondingResult = await _mapboxService.ReverseGeocodingAsync(reverseParameters);
        }
    }
}
