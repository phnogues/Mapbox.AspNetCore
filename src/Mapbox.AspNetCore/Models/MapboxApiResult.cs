using System.Collections.Generic;

namespace Mapbox.AspNetCore.Models;

public class Properties
{
    public string accuracy { get; set; }
}

public class Geometry
{
    public string type { get; set; }
    public List<double> coordinates { get; set; }
}

public class Context
{
    public string id { get; set; }
    public string text { get; set; }
    public string wikidata { get; set; }
    public string short_code { get; set; }
}

public class Feature
{
    public string id { get; set; }
    public string type { get; set; }
    public List<string> place_type { get; set; }
    public double relevance { get; set; }
    public Properties properties { get; set; }
    public string text { get; set; }
    public string place_name { get; set; }
    public List<double>? bbox { get; set; }
    public List<double> center { get; set; }
    public Geometry geometry { get; set; }
    public List<Context> context { get; set; }
    public string matching_text { get; set; }
    public string matching_place_name { get; set; }
    public string address { get; set; }
}

public class MapboxApiResult
{
    public string type { get; set; }
    public List<object> query { get; set; }
    public List<Feature> features { get; set; }
    public string attribution { get; set; }
}
