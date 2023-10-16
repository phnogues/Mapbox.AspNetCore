namespace Mapbox.AspNetCore.Models;

public enum DataType
{
    Country,
    Region,
    PostCode,
    District,
    Place,
    Locality,
    Neighborhood,
    Address,
    Poi
}

internal static class DataTypeExtensions
{
    internal static string ApiValue(this DataType dataType)
    {
        return dataType switch
        {
            DataType.Country => "country",
            DataType.Region => "region",
            DataType.PostCode => "postcode",
            DataType.District => "district",
            DataType.Place => "place",
            DataType.Locality => "locality",
            DataType.Neighborhood => "neighborhood",
            DataType.Address => "address",
            DataType.Poi => "poi",
            _ => throw new ArgumentOutOfRangeException(nameof(dataType), dataType, null)
        };
    }
}