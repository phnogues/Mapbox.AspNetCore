using Mapbox.AspNetCore.Interfaces;
using Mapbox.AspNetCore.Models;
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

        public MapboxResult MapboxResult { get; set; }

        public string Query { get; set; } = "Avenue Anatole France, Paris";
        public string CountryCode { get; set; } = "FR";
        public double MinRelevance { get; set; } = 0.6;

        public async Task OnGet()
        {
            var parameters = new GeocodingParameters()
            {
                Query = this.Query,
                CountryCode = this.CountryCode,
                Proximity = new GeoCoordinate(48.858256895096574, 2.2943737309434593),
                Limit = 10,
                MinRelevance = this.MinRelevance
            };

            MapboxResult = await _mapboxService.GeocodingAsync(parameters);
        }
    }
}
