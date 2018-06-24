using Microsoft.Extensions.Logging;

namespace DotNetConsoleStuff.App
{
    public class Application : IApplication
    {
        public Application(ILogger<Application> logger, IAppSettings appSettings)
        {
            Logger = logger;
            AppSettings = appSettings;
        }

        private ILogger<Application> Logger { get; }
        private IAppSettings AppSettings { get; }

        public void Run()
        {
            System.Console.WriteLine(AppSettings.Message);
        }
    }
}
