using Microsoft.Extensions.Configuration;

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

        }
    }
}
