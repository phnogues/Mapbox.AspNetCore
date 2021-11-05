using System.Collections.Generic;

namespace Mapbox.AspNetCore.Models
{
    public class MapboxResult
    {
        public Place Place { get; set; }
    }

    public class MapboxResults
    {
        public MapboxResults()
        {
            Places = new List<Place>();
        }

        public List<Place> Places { get; set; }
    }

    public class Place
    {
        public string Text { get; set; }

        public string Name { get; set; }

        public double Relevance { get; set; }

        public GeoCoordinate Coordinates { get; set; }

        public Country Country { get; set; }

        public Region Region { get; set; }

        public City City { get; set; }
    }

    public class Country : ContextBase
    {
    }

    public class Region : ContextBase
    {
    }

    public class City
    {
        public string Name { get; set; }

        public string PostCode { get; set; }
    }

    public class ContextBase
    {
        public string ShortCode { get; set; }
        public string Name { get; set; }
    }
}
