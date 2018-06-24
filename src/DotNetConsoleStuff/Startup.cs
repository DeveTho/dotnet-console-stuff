using DotNetConsoleStuff.App;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;
using System.IO;

namespace DotNetConsoleStuff
{
    public static class Startup
    {
        public static IServiceProvider Configure()
        {
            var configuration = SetupConfiguration();
            var serviceProvider = ConfigureDependencyInjection(configuration);

            return serviceProvider;
        }

        private static IConfiguration SetupConfiguration()
        {
            var environmentName = ConfigurationManager.AppSettings["EnvironmentName"];

            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environmentName}.json", optional: true);

            return configurationBuilder.Build();
        }

        private static IServiceProvider ConfigureDependencyInjection(IConfiguration configuration)
        {
            var services = new ServiceCollection();

            var appsettings = configuration.Get<AppSettings>();
            services.AddSingleton<IAppSettings>(appsettings);

            services.AddScoped<IApplication, Application>();

            return services.BuildServiceProvider(validateScopes: true);
        }
    }
}
