using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetVersions.Benchmarks
{
    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(RuntimeMoniker.CoreRt31)]
    [SimpleJob(RuntimeMoniker.Net50)]
    [SimpleJob(RuntimeMoniker.Net60)]
    [SimpleJob(RuntimeMoniker.CoreRt60)]
    [SimpleJob(RuntimeMoniker.HostProcess)]
    [MonoJob]
    [Orderer(SummaryOrderPolicy.FastestToSlowest,
        MethodOrderPolicy.Declared)]
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByMethod)]
    [HtmlExporter, JsonExporterAttribute.Full, MarkdownExporterAttribute.GitHub]
    public class BaseBenchmark
    {
    }
}
