using Mapbox.AspNetCore.Models;
using System.Threading.Tasks;

namespace Mapbox.AspNetCore.Interfaces
{
    public interface IMapboxService
    {
        Task<MapboxResults> GeocodingAsync(GeocodingParameters parameters);
        Task<MapboxResult> ReverseGeocodingAsync(ReverseGeocodingParameters parameters);
    }
}
