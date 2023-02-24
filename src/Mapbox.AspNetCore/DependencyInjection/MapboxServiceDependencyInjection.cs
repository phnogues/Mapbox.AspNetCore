using Microsoft.Extensions.DependencyInjection;

namespace Mapbox.AspNetCore.DependencyInjection;

public static class MapboxServiceDependencyInjection
{
    public static IServiceCollection AddMapBoxServices(this IServiceCollection services, Action<Options> optionsBuilder, bool serviceIsRequired = true)
    {
        if (optionsBuilder == null)
        {
            if (serviceIsRequired)
            {
                throw new ArgumentException("Please use options to set the ApiKey");
            }
            else
            {
                Console.WriteLine("ApiKey not specified");
            }
        }

        var options = new Options();
        optionsBuilder(options);

        if (string.IsNullOrEmpty(options.ApiKey))
        {
            string message = "Please use your MapBox API key (available on the developer website)";
            if (serviceIsRequired)
            {
                throw new ArgumentException(message);
            }
            else
            {
                Console.WriteLine(message);
            }
        }

        services.AddSingleton<IMapboxKeyService>(new MapboxKeyService(options.ApiKey));
        services.AddHttpClient<IMapboxService, MapBoxService>();

        return services;
    }
}
