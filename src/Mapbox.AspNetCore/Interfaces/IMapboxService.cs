using Mapbox.AspNetCore.Models;
using System.Threading.Tasks;

namespace Mapbox.AspNetCore.Interfaces
{
    public interface IMapboxService
    {
        Task<MapboxResult> GeocodingAsync(GeocodingParameters parameters);
    }
}
