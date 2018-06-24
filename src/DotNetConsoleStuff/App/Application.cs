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
            throw new System.NotImplementedException();
        }
    }
}
