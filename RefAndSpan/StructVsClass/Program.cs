using System;
using System.Collections.Generic;
using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace StructVsClass
{
	/// <summary>
	/// A simple reference type
	/// </summary>
	public class Point_Class
	{
		public int x; //to have a fair benchmark let's not use properties.
		public int y;
	}

	/// <summary>
	/// A value type that properly imlpements the equals method to avoid boxin and reflection
	/// </summary>
	public struct Point_Struct_ProperImplementation : IEquatable<Point_Struct_ProperImplementation>
	{
		public int x;
		public int y;

		public override bool Equals(object obj)
		{
			return obj is Point_Struct_ProperImplementation && Equals((Point_Struct_ProperImplementation)obj);
		}

		public bool Equals(Point_Struct_ProperImplementation other)
		{
			return x == other.x &&
				   y == other.y;
		}

		public override int GetHashCode()
		{
			var hashCode = 1502939027;
			hashCode = hashCode * -1521134295 + base.GetHashCode();
			hashCode = hashCode * -1521134295 + x.GetHashCode();
			hashCode = hashCode * -1521134295 + y.GetHashCode();
			return hashCode;
		}

		public static bool operator ==(Point_Struct_ProperImplementation point1, Point_Struct_ProperImplementation point2)
		{
			return point1.Equals(point2);
		}

		public static bool operator !=(Point_Struct_ProperImplementation point1, Point_Struct_ProperImplementation point2)
		{
			return !(point1 == point2);
		}
	}

	public class Program
	{
		static void Main(string[] args)
		{
			var summary = BenchmarkRunner.Run<Program>();
		}

		static List<Point_Struct_ProperImplementation> StructList = new List<Point_Struct_ProperImplementation>();
		static List<Point_Class> ClassList = new List<Point_Class>();

		static Program()
		{
			var rnd = new Random();
			for (int i = 0; i < 1_000_000; i++)
			{
				var x = rnd.Next();
				var y = rnd.Next();
				StructList.Add(new Point_Struct_ProperImplementation() { x = x, y = y});
				ClassList.Add(new Point_Class { x = x, y = y });
			}

		}

		[Benchmark]
		public static void ManyClasses()
		{
			for (int i = 0; i < 1_000_000; i++)
			{
				if(ClassList[i].x == -1)
				{
					Debug.WriteLine("-1");
				}
			}
		}

		[Benchmark]
		public static void ManyStructs_ProperImplementation()
		{
			for (int i = 0; i < 1_000_000; i++)
			{
				if (StructList[i].x == -1)
				{
					Debug.WriteLine("-1");
				}
			}
		}
	}
}
