using System;

namespace SpanBasics
{
	class Program
	{
		static void Main(string[] args)
		{
			byte[] array = new byte[] { 1, 2, 3, 4 };
			Span<byte> span = new Span<byte>(array);
			Span<byte> newSpan = span.Slice(1, 3);
		}
	}
}
