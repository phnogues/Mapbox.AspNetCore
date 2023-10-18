using System.Collections.Generic;

namespace Mapbox.AspNetCore.Models;

public class ReverseGeocodingParameters
{
    public GeoCoordinate Coordinates { get; set; }
    
    /// <summary>
    /// Filter results to include only a subset (one or more) of the available feature types
    /// </summary>
    public IEnumerable<DataType> Types { get; set; }
}
