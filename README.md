# DotNetVersions

## Versions
.NET Framework 4.8
.NET Core 3.1 | .NET Core RT 3.1
.NET 5.0 | 6.0 | RT 6.0 | ? (if Host 7.0, then 7.0)
Mono | MonoAOTLLVM

-------
## Setup
To be able to execute the benchmarks, you must install all these frameworks.
You can get them here:
  [.NET Framework](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48)
  [.NET Core 3.1](https://dotnet.microsoft.com/en-us/download/dotnet/3.1)
  [.NET 5.0](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)
  [.NET 6.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) 
  [Mono](https://www.mono-project.com/download/stable/)
  [LLVM](https://github.com/llvm/llvm-project/releases/tag/llvmorg-14.0.6)
To be able to run Mono with AOT and LLVM you will need to install both Mono, LLVM and some linker executable, normally some form Visual Studio compilers.
  
## Running
To run, you should build and execute the console project
To build you can use the 'build.cmd' script
To run you can use the 'run-benchmarks.cmd' script
