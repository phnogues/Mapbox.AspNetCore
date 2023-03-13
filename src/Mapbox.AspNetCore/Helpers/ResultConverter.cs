using System.Linq;

namespace Mapbox.AspNetCore.Helpers;

public static class ResultConverter
{
    public static MapboxResults ConvertResults(this MapboxApiResult apiResults)
    {
        MapboxResults result = new MapboxResults();

        foreach (var place in apiResults.features)
        {
            var country = place.context.FirstOrDefault(p => p.id.StartsWith("country"));
            var region = place.context.FirstOrDefault(p => p.id.StartsWith("region"));
            var city = place.context.FirstOrDefault(p => p.id.StartsWith("place"));
            var postCode = place.context.FirstOrDefault(p => p.id.StartsWith("postcode"));
            var locality = place.context.FirstOrDefault(p => p.id.StartsWith("locality"));

            var newPlace = new Place()
            {
                Name = place.place_name,
                Text = place.text,
                Relevance = place.relevance,
                Coordinates = new GeoCoordinate(place.center[1], place.center[0])
            };

            if (country != null)
            {
                newPlace.Country = new Country()
                {
                    Name = country.text,
                    ShortCode = country.short_code
                };
            }

            if (region != null || locality != null)
            {
                newPlace.Region = new Region()
                {
                    Name = region != null ? region.text : locality?.text,
                    ShortCode = region != null ? region.short_code : null,
                };
            }

            if (city != null)
            {
                newPlace.City = new City()
                {
                    Name = city.text,
                    PostCode = postCode?.text
                };

                if (postCode is null)
                {
                    // try to get it from feature
                    newPlace.City.PostCode = place.place_type?[0] == "postcode" ? place.text : null;
                }
            }

            result.Places.Add(newPlace);
        }

        return result;
    }
}
