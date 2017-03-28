Commands
------------
nuget setApiKey xxx-xxx-xxxx-xxxx

nuget pack ..\Sangmado.Inka.Logging.NLogIntegration\Sangmado.Inka.Logging.NLogIntegration.csproj -IncludeReferencedProjects -Symbols -Build -Prop Configuration=Release -OutputDirectory ".\packages"

nuget push .\packages\Sangmado.Inka.Logging.NLogIntegration.1.0.0.0.nupkg

