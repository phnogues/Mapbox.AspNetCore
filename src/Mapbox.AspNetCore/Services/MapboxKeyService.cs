using Mapbox.AspNetCore.Interfaces;

namespace Mapbox.AspNetCore.Services
{
    public class MapboxKeyService : IMapboxKeyService
    {
        private readonly string _apiKey;

        public MapboxKeyService(string apiKey)
        {
            this._apiKey = apiKey;
        }

        public string ApiKey()
        {
            return _apiKey;
        }
    }
}
