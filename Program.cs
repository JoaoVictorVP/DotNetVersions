using BenchmarkDotNet.Running;
using DotNetVersions.Benchmarks;

Console.WriteLine("Benchmark for .NET versions");

BenchmarkRunner.Run<ForStrings>();
