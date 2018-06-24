using DotNetConsoleStuff.App;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetConsoleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = Startup.Configure();

            using (var scope = serviceProvider.CreateScope())
            {
                var app = scope.ServiceProvider.GetRequiredService<IApplication>();
                app.Run();
            }
        }
    }
}
