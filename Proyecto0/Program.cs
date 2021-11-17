using BenchmarkDotNet.Running;
using System;

namespace Proyecto0
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<ParserDateBenchmark>();
            Console.WriteLine("Hello World!");
        }
    }
}
