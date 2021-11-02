using System;

namespace Mapbox.AspNetCore.Models
{
    public class Options
    {
        public string ApiKey { get; private set; }

        public Options UseApiKey(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
            {
                throw new ArgumentException("Please use your MapBox API key (available on the developer website)");
            }

            ApiKey = apiKey;
            return this;
        }
    }
}
