namespace Mapbox.AspNetCore.Models.Proximity;

public class ProximityCoordinates : IProximity
{
    public ProximityCoordinates(GeoCoordinate geoCoordinate) => Coordinates = geoCoordinate;

    public ProximityCoordinates(double latitude, double longitude) => Coordinates = new GeoCoordinate(latitude, longitude);

    public GeoCoordinate Coordinates { get; set; }

}
