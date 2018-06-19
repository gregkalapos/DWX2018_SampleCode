using System;
using System.Buffers;

namespace ArrayPoolSample
{
	class Program
	{
		static void Main(string[] args)
		{
			ArrayPool<int> a = ArrayPool<int>.Shared;
		}
	}
}
