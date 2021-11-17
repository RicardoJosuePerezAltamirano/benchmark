using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    [SimpleJob(RunStrategy.ColdStart, targetCount:5)]
    class TestCouldStart
    {
    }
}
