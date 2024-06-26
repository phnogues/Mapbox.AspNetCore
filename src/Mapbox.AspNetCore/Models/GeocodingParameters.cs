﻿using System.Collections.Generic;

namespace Mapbox.AspNetCore.Models;

public class GeocodingParameters
{
    public string Query { get; set; }

    /// <summary>
    /// Filter by country code, two letters country code
    /// </summary>
    public string CountryCode { get; set; }

    /// <summary>
    /// Response text language, two letters language code
    /// </summary>
    public string Language { get; set; }

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

    /// <summary>
    /// Filter results to include only a subset (one or more) of the available feature types
    /// </summary>
    public IEnumerable<DataType> Types { get; set; }
}