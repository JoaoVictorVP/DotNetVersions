dotnet build -c Release -f net48
dotnet build -c Release -f netcoreapp3.1
dotnet build -c Release -f net5.0
dotnet build -c Release -f net6.0
mono --aot -O=all "bin/Release/net48/DotNetVersions.exe"
pause