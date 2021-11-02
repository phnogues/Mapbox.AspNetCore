namespace Mapbox.AspNetCore.Models
{
    public class GeocodingParameters
    {
        public string Query { get; set; }
        public string CountryCode { get; set; }
        public int Limit { get; set; } = 5;
        public GeoCoordinate Proximity { get; set; }
        public double MinRelevance { get; set; }
    }
}
