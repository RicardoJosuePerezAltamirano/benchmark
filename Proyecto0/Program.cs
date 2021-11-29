using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using System;

namespace Proyecto0
{
    class Program
    {
        static void Main(string[] args)
        {
            // BenchmarkRunner.Run<ParserDateBenchmark>();
            BenchmarkRunner.Run<ParserDateBenchmark>(DefaultConfig.Instance
                 .AddJob(Job.Default.WithRuntime(ClrRuntime.Net48))
                 .AddJob(Job.Default.WithRuntime(CoreRuntime.Core50))
                 .AddJob(Job.Default.WithRuntime(CoreRuntime.Core60))

                 .AddJob(Job.Default.WithRuntime(CoreRuntime.Core31))
                 );
            Console.WriteLine("Hello World!");
        }
    }
}
