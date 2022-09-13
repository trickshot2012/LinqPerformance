using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPerformance
{
    [MemoryDiagnoser(false)]
  
    public class Benchmarks
    {
        [Params(100)]
        public int Size { get; set; }

        private IEnumerable<int> _items;

        [GlobalSetup]
        public void Setup()
        {
            _items = Enumerable.Range(1,Size).ToArray();
        }

        [Benchmark]
        public int Max()=> _items.Max();

        [Benchmark]
        public int Min()=> _items.Min();

        [Benchmark]
        public double Average()=> _items.Average();

        [Benchmark]
        public int Sum() => _items.Sum();   


    }
}
