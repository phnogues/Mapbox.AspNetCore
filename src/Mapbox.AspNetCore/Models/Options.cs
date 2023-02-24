namespace Mapbox.AspNetCore.Models;

public class Options
{
    public string ApiKey { get; private set; }

    public Options UseApiKey(string apiKey)
    {
        ApiKey = apiKey;
        return this;
    }
}
