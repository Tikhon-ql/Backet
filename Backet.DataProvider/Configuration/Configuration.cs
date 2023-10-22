using Backet.Common.Interfaces;
using Backet.DataProvider.Context;
using Backet.DataProvider.Interfaces;
using Backet.DataProvider.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backet.DataProvider.Configuration
{
    public static class Configuration
    {
        public static void ConfigureDataProviderLayer(this IServiceCollection services, IConfiguration configuration)
        {
            //var connectionString = Environment.GetEnvironmentVariable("ApplicationConnectionString");
            //Debug.WriteLine("Connection string: " + connectionString);
            //Console.WriteLine("Connection string: " + connectionString);
            var connectionString = configuration.GetConnectionString("ApplicationConnectionString");
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(connectionString).UseLazyLoadingProxies();
            });

            services.AddScoped<IPlayStatsRepository, PlayStatsRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRefreshTokenRepository, RefreshTokenRepository>();
            services.AddScoped<IRoleRepository,RoleRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
