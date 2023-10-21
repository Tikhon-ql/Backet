using Backet.DataProvider.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Backet.Logic.Configuration
{
    public static class Configuration
    {
        public static void ConfigureLogicLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureDataProviderLayer(configuration);
        }
    }
}
