using Backet.DataProvider.Configuration;
using Backet.Logic.Interfaces;
using Backet.Logic.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Backet.Logic.Configuration
{
    public static class Configuration
    {
        public static void ConfigureLogicLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureDataProviderLayer(configuration);
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IPlayStatsService, PlayStatsService>();
        }
    }
}
