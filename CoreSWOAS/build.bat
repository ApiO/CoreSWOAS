@echo off

dotnet restore src
dotnet build src
echo.
pause