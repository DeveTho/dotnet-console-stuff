# DotNetConsoleStuff

A .NET console app (targeting .NET Framework 4.6.2) that uses configuration, dependency injection and logging as by default used in ASP.NET Core.

* Create solution in src directory
  * Add .gitignore and .editorconfig
  * Add src solution directory
  * Add console app project (.NET Core) and adapt targeting to net462
* Add App.config + transforms + update csproj for nesting
  * Transforms are not used by default for App.config. Your CD system can use another way (e.g. replacing a string)
* Add appsettings.json file + environment specific + update csproj for nesting and CopyToOutputDirectory
    * Add a dummy `message` property to the appsettings
* Add reference to `System.Configuration`
* Add following package references:
```xml
<PackageReference Include="Microsoft.Extensions.Configuration.Binder" Version="2.1.1" />
<PackageReference Include="Microsoft.Extensions.Configuration.Json" Version="2.1.1" />
```