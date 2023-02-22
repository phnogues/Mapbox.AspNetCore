namespace Mapbox.AspNetCore.Models;

public class GeocodingParameters
{
    public string Query { get; set; }
    public string CountryCode { get; set; }
    public int Limit { get; set; } = 5;

    /// <summary>
    /// ProximityCoordinates / ProximityIp / None
    /// </summary>
    public IProximity Proximity { get; set; }
    public double MinRelevance { get; set; }
    public bool AutoComplete { get; set; }

    /// <summary>
    /// Only returns cities with this postal code.
    /// </summary>
    public string PostCodeOnly { get; set; }
    public bool IpProximity { get; set; }
}