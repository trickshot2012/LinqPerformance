//var item = Enumerable.Range(1, 100);


//var max=item.Max();
//var min = item.Min();
//var average=item.Average();
//var sum=item.Sum();
using BenchmarkDotNet.Running;
using LinqPerformance;

BenchmarkRunner.Run<Benchmarks>();
