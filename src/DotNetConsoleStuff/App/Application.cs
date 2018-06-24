namespace DotNetConsoleStuff.App
{
    public class Application : IApplication
    {
        public Application(IAppSettings appSettings)
        {
            AppSettings = appSettings;
        }

        private IAppSettings AppSettings { get; }

        public void Run()
        {
            System.Console.WriteLine(AppSettings.Message);
        }
    }
}
