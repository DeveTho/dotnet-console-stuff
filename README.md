# DotNetConsoleStuff

A .NET console app (targeting .NET Framework 4.6.2) that uses configuration, dependency injection and logging as by default used in ASP.NET Core, using the separately available NuGet packages.

---

**Setup**

* Create solution in src directory
  * Add .gitignore and .editorconfig
  * Add src solution directory
  * Add console app project (.NET Core) and adapt targeting to net462
* Add App.config + transforms + update csproj for nesting
  * Transforms are not used by default for App.config. Your CD system can use another way (e.g. replacing a string)

---

**Configuration**

* Add appsettings.json file + environment specific + update csproj for nesting and CopyToOutputDirectory
    * Add a dummy `message` property to the appsettings
* Add reference to `System.Configuration`
* Add following package references:

```xml
<PackageReference Include="Microsoft.Extensions.Configuration.Binder" Version="2.1.1" />
<PackageReference Include="Microsoft.Extensions.Configuration.Json" Version="2.1.1" />
```

* Create static `Startup` class
  * Create public method `void Configure()`
  * Create private method `IConfiguration SetupConfiguration()`
  * Implement SetupConfiguration method
  * Temporarily `Console.WriteLine()` message property
  * Call Startup in Program.Main()
  * Run app
  * Edit EnvironmentName and rerun (also with an unknown value)

**Dependency injection**

* Add following package reference:

```xml
<PackageReference Include="Microsoft.Extensions.DependencyInjection" Version="2.1.1" />
```

* Add an `IApplication` interface and an `Application` class in the `App` folder
  * These are the main entry point of the app and will further resolve any other dependencies by themselves  
  * Add a method `void Run()`
* Add an `IAppSettings` interface and an `AppSettings` class in the `App` folder
  * They will match our specified properties in appsettings.json as a strongly typed model, and are injectable
  * Add a property `string Message { get; }`
    * Also add a `set` in the class!
* Inject the IAppSettings in the constructor of Application + add property
  * Write the AppSettings message in `Application.Run()` using `Console.WriteLine()`
  * Remove the `Console.WriteLine()` in the `Startup` class
* Further configure `Startup` class