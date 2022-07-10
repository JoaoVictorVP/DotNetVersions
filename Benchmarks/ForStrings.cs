using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using DotNetVersions.Assets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVersions.Benchmarks
{
    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.CoreRt31)]
    [SimpleJob(RuntimeMoniker.Net50)]
    [SimpleJob(RuntimeMoniker.Net60)]
    [SimpleJob(RuntimeMoniker.Mono)]
    [SimpleJob(RuntimeMoniker.HostProcess)]
    [HtmlExporter, MarkdownExporterAttribute.GitHub]
    public class ForStrings
    {
        private readonly string text;
        private readonly int textSize;
        private readonly string[] splitWith = new string[] { "tincidunt" };

        public ForStrings()
        {
            text = SampleText.Text;
            textSize = text.Length;
        }

        [Benchmark]
        public int FindIndexOf()
        {
            return text.IndexOf("Vestibulum ullamcorper odio tellus.");
        }

        [Benchmark]
        public string Replace()
        {
            return text.Replace("Vestibulum ullamcorper odio tellus.", "This is a test...");
        }

        [Benchmark]
        public string Remove()
        {
            return text.Remove(textSize - 30);
        }

        [Benchmark]
        public bool Contains()
        {
            return text.Contains("tellus");
        }

        [Benchmark]
        public string[] Split()
        {
            return text.Split(splitWith, StringSplitOptions.RemoveEmptyEntries);
        }

        [Benchmark]
        public string Substring()
        {
            return text.Substring(textSize - 50, 10);
        }

        [Benchmark]
        public ReadOnlySpan<char> SubstringWithSpan()
        {
            return text.AsSpan().Slice(textSize - 50, 10);
        }

        [Benchmark]
        public long IterateAndSumChars()
        {
            long sum = 0;
            for (int i = 0; i < textSize; i++)
                sum += text[i];
            return sum;
        }

        [Benchmark]
        public long IterateAndSumCharsUsingSpan()
        {
            long sum = 0;
            var textSpan = text.AsSpan();
            for (int i = 0; i < textSize; i++)
                sum += textSpan[i];
            return sum;
        }
    }
}