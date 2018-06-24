using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.IO;

namespace DotNetConsoleStuff
{
    public static class Startup
    {
        public static void Configure()
        {
            var configuration = SetupConfiguration();
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
    }
}
