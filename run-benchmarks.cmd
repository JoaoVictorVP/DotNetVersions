dotnet run -c Release -f net48
dotnet run -c Release -f netcoreapp3.1
dotnet run -c Release -f net5.0
dotnet run -c Release -f net6.0
mono "bin/Release/net48/DotNetVersions.exe"
mono "bin/Release/net48/DotNetVersions.exe" --llvm
pause