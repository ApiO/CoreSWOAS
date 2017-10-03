@echo off

dotnet restore Presentation/CoreSWOAS
dotnet build Presentation/CoreSWOAS
echo.
pause