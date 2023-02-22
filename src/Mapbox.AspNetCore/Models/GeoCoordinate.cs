namespace Mapbox.AspNetCore.Models;

public class GeoCoordinate
{
    public GeoCoordinate()
    {
    }

    public GeoCoordinate(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    public double Latitude { get; set; }

    public double Longitude { get; set; }
}
