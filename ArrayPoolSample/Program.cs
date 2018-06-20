using System;
using System.Buffers;
using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace ArrayPoolSample
{
	[MemoryDiagnoser]
	public class Program
	{
		static void Main(string[] args)
		{
			var summary = BenchmarkRunner.Run<Program>();
		}

		[Benchmark]
		public static void ArrayPoolBenchmark()
		{
			for (int i = 0; i < 1000; i++)
			{
				MethodCalledOften_ArrayPool();
			}
		}

		[Benchmark]
		public static void NoPoolBenchmark()
		{
			for (int i = 0; i < 1000; i++)
			{
				MethodCalledOften_NoPooling();
			}
		}

		public static void MethodCalledOften_NoPooling()
		{
			var arr = new int[256 * 1024];
			Debug.WriteLine(arr[0].ToString());
			//use arr.
		}

		public static void MethodCalledOften_ArrayPool()
		{
			var arr = ArrayPool<int>.Shared.Rent(256 * 1024);
			Debug.WriteLine(arr[0].ToString());
			//use arr.
			ArrayPool<int>.Shared.Return(arr);
		}
	}
}
