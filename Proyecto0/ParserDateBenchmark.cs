using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto0
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]// formateo 
    public class ParserDateBenchmark
    {
        private const string Date = "2021-11-17T01:27:00";
        private static readonly ParserDate parserDate = new ParserDate();

        [Benchmark(Baseline =true)] // desde donde iniciara y despues intentara optimizarse
        public void GetYearFromDateTime()
        {
            parserDate.GetYearFromDatetime(Date);
        }
        [Benchmark]
        public void GetYearFromDateTimeSplit()
        {
            parserDate.GetYearFromSpit(Date);
        }
        [Benchmark]
        public void GetYearFromDateTimeSubstring()
        {
            parserDate.GetYearFromSubstring(Date);
        }
        [Benchmark]
        public void GetYearFromDateTimeSpan()
        {
            parserDate.GetYearFromSpan(Date);
        }
    }
}
