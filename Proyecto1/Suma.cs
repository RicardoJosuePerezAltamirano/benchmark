using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.CoreRt50)]
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.CoreRt31)]
    //[SimpleJob(runtimeMoniker: RuntimeMoniker.Net472)]
    //[ClrJob, CoreJob, MonoJob, CoreRtJob]
    [MemoryDiagnoser]
    public class Suma
    {
        [Benchmark]
        public void Metodo1()
        {
            var a = 1;
            var b = 2;
            var response = a + b;
        }
        [Benchmark]
        public void Metodo2()
        {

            var response = new List<int>() { 1, 2 }.Sum();

        }
    }
}
