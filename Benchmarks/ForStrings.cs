using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Order;
using DotNetVersions.Assets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVersions.Benchmarks
{
    public class ForStrings : BaseBenchmark
    {
        public const int AddCount = 10000;
        public const int ConcatCount = 100;

        private readonly string text;
        private readonly int textSize;
        private readonly string[] splitWith = new string[] { "tincidunt" };
        private readonly string[] toConcat;

        public ForStrings()
        {
            text = SampleText.Text;
            textSize = text.Length;
            toConcat = BuildToConcat();
        }
        string[] BuildToConcat()
        {
            string[] toConcat = new string[ConcatCount];
            for (int i = 0; i < ConcatCount; i++)
                toConcat[i] = text;
            return toConcat;
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

        [Benchmark]
        public string StringAdd()
        {
            string result = "";
            for (int i = 0; i < AddCount; i++)
                result += text;
            return result;
        }

        [Benchmark]
        public string StringConcat()
        {
            return string.Concat(toConcat);
        }

        [Benchmark]
        public string ToUpper()
        {
            return text.ToUpper();
        }

        [Benchmark]
        public string ToLower()
        {
            return text.ToLower();
        }
    }
}