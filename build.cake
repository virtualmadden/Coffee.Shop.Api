//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

//////////////////////////////////////////////////////////////////////
// PREPARATION
//////////////////////////////////////////////////////////////////////

// Define directories.
var buildDir = Directory("./Coffee.Shop.Api/Coffee.Shop.Api/bin");
var solution = "./Coffee.Shop.Api/Coffee.Shop.Api.sln";

var settings = new DotNetCoreBuildSettings {
         Framework = "netcoreapp1.0",
         Configuration = configuration,
         OutputDirectory = buildDir
     };

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Clean")
    .Description("Cleaning the build directory.")
    .Does(() =>
{
    CleanDirectory(buildDir);
});

Task("Restore-NuGet-Packages")
    .IsDependentOn("Clean")
    .Description("Restoring NuGet packages.")
    .Does(() =>
{
    NuGetRestore(solution);
});

Task("Build")
    .IsDependentOn("Restore-NuGet-Packages")
    .Description("Building the solution.")
    .Does(() =>
{
    DotNetCoreBuild(solution, settings);
});

Task("Run-Unit-Tests")
    .IsDependentOn("Build")
    .Description("Runs Unit tests.")
    .Does(() =>
{
    NUnit3("./Coffee.Shop.Api/**/bin/*.Tests.dll", new NUnit3Settings {
        NoResults = true
    });
});

//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////

Task("Default")
    .IsDependentOn("Run-Unit-Tests");

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);