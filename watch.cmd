@echo off
start /d .\client npm run watch
echo waiting for client to build...
timeout 60
start /d .\host dotnet watch --project .\host.csproj run
exit