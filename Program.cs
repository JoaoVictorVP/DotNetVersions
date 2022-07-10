using BenchmarkDotNet.Running;
using DotNetVersions.Benchmarks;
using System;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Benchmark for .NET versions");

        BenchmarkRunner.Run<ForStrings>();
    }
}