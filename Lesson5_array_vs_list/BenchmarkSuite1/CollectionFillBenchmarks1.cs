using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using Microsoft.VSDiagnostics;

namespace Lesson5_array_vs_list.Benchmarks
{
    [CPUUsageDiagnoser]
    public class CollectionFillBenchmarks
    {
        [Params(1000, 10000, 100000)]
        public int N { get; set; }

        private int[] source;
        [GlobalSetup]
        public void Setup()
        {
            source = new int[N];
            var rnd = new Random(42);
            for (int i = 0; i < N; i++)
                source[i] = rnd.Next();
        }

        [Benchmark(Baseline = true)]
        public int[] FillArray()
        {
            var arr = new int[N];
            for (int i = 0; i < N; i++)
                arr[i] = source[i];
            return arr;
        }

        [Benchmark]
        public List<int> FillList_Default()
        {
            var list = new List<int>();
            for (int i = 0; i < N; i++)
                list.Add(source[i]);
            return list;
        }

        [Benchmark]
        public List<int> FillList_WithCapacity()
        {
            var list = new List<int>(N);
            for (int i = 0; i < N; i++)
                list.Add(source[i]);
            return list;
        }
    }
}