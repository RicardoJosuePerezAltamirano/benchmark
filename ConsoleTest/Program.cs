using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Security.Cryptography;

namespace ConsoleTest
{
    [ClrJob, CoreJob, MonoJob, CoreRtJob, MinColumn, MaxColumn, HtmlExporter]
    public class Md5VsSha256
    {
        private SHA256 sha256 = SHA256.Create();
        private MD5 md5 = MD5.Create();
        private byte[] data;
        [Params(1000, 10000)]
        public int N;
        [GlobalSetup]
        public void Setup()
        {
            data = new byte[N];
            new Random(42).NextBytes(data);
        }
        [Benchmark]
        public byte[] Sha256() => sha256.ComputeHash(data);
        [Benchmark]
        public byte[] Md5() => md5.ComputeHash(data);
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // var summary = BenchmarkRunner.Run<Md5VsSha256>();
            //var objtest = new TestMethods();
            //objtest.Time100();
            //objtest.Time150();
            //objtest.Time50();

            var summary = BenchmarkRunner.Run<TestMethods>();

            Console.ReadLine();
        }
    }
}
