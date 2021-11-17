using BenchmarkDotNet.Running;
using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;


namespace Proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var summary = BenchmarkRunner.Run<Suma>();
            var config = DefaultConfig.Instance
               .With(Job.Default.With(CoreRuntime.Core22))
                .With(Job.Default.With(CoreRuntime.Core31))
               .With(Job.Default.With(CoreRuntime.Core50))
               .With(Job.Default.With(ClrRuntime.Net48));

            BenchmarkSwitcher
                .FromAssembly(typeof(Program).Assembly)
                .Run(config:config);
            Console.ReadLine();
        }
    }
}
