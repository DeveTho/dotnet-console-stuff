# DotNetConsoleStuff

A .NET console app (targeting .NET Framework 4.6.2) that uses configuration, dependency injection and logging as by default used in ASP.NET Core.

* Create solution in src directory
  * Add .gitignore and .editorconfig
  * Add src solution directory
  * Add console app project (.NET Core) and adapt targeting to net462
* Add App.config + transforms + update csproj for nesting
  * Transforms are not used by default for App.config. Your CD system can use another way (e.g. replacing a string)
* Add appsettings.json file + environment specific + update csproj for nesting and CopyToOutputDirectory
    * Add a `message` property to the appsettings