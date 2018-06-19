using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Running;
using LibToBenchmark;

namespace Benchmark_Linq_DotNetCoreVsFullFramework
{
	[ClrJob, CoreJob]
	[MemoryDiagnoser]
	[DisassemblyDiagnoser(printAsm: true, printSource: true, printIL: true)]
	public class Program
	{
		static List<HistoricalValue> HisticalPrices;

		static Program()
		{
			HistoricalPriceReader reader = new HistoricalPriceReader();
			HisticalPrices = reader.GetHistoricalQuotes("MSFT").ToList();
		}
		static void Main(string[] args)
		{
			var summary = BenchmarkRunner.Run<Program>();
		}

		[Benchmark]
		public static void CalculateWithLinq()
		{
			var linqres = SimpleMovingAverage.CalculateSMALinq(HisticalPrices, 14);
			Debug.WriteLine(linqres.Count);
		}
	}
}
