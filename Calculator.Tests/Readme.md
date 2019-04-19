# Writing Test cases

Create a new project, by running command

dotnet new xunit

Running tests

To use Visual studio test run dotnet test

To get converage of branch

dotnet test /p:CollectCoverage=true
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=lcov

To generate report

dotnet tool install --global dotnet-reportgenerator-globaltool
reportgenerator -reports:.\coverage.opencover.xml -targetdir:C:\Pluralsight\code\Calculator\Calculator.Tests\Report

## Coverlet tooling

dotnet tool install --global coverlet.console

### to use coverlet

coverlet --help
coverlet .\bin\MCD\Debug\netcoreapp2.2\Calculator.Tests.dll --target "dotnet" --targetargs "test --no-build"
coverlet .\bin\MCD\Debug\netcoreapp2.2\Calculator.Tests.dll --target "dotnet" --targetargs "test --no-build" --format opencover

## Define threshold

dotnet test /p:CollectCoverage=true /p:Threshold=100 /p:CoverletOutputFormat=opencover

## Extensions

## Adding project reference

cd Calculator.Tests
dotnet add reference ..\Calculator.Console\Calculator.Console.csproj

## Adding nuget packages

dotnet add package coverlet.msbuild
dotnet add package FluentAssertions
dotnet add package dotnet-xunit

## For reference

Using coverlet from .net core <https://www.youtube.com/watch?v=vdAyb4W8gp4/>
Setting up Jenkins in windows <https://dzone.com/articles/how-to-install-jenkins-on-windows/>
Report Generator <https://github.com/danielpalme/ReportGenerator/>