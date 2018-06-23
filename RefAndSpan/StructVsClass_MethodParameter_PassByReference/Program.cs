using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace StructVsClass_MethodParameter_PassByReference
{
	public struct Matrix_Struct
	{
		public int i00, i01, i02;
		public int i10, i11, i12;
		public int i20, i21, i22;

		public Matrix_Struct(int i00, int i01, int i02, int i10, int i11, int i12, int i20, int i21, int i22)
		{
			this.i00 = i00;
			this.i01 = i01;
			this.i02 = i02;

			this.i10 = i10;
			this.i11 = i11;
			this.i12 = i12;

			this.i20 = i20;
			this.i21 = i21;
			this.i22 = i22;
		}
	}

	public class Matrix_Class
	{
		public int i00, i01, i02;
		public int i10, i11, i12;
		public int i20, i21, i22;

		public Matrix_Class(int i00, int i01, int i02, int i10, int i11, int i12, int i20, int i21, int i22)
		{
			this.i00 = i00;
			this.i01 = i01;
			this.i02 = i02;

			this.i10 = i10;
			this.i11 = i11;
			this.i12 = i12;

			this.i20 = i20;
			this.i21 = i21;
			this.i22 = i22;
		}
	}

	public class Program
	{

		static Random Random = new Random();

		static void Main(string[] args)
		{
			var summary = BenchmarkRunner.Run<Program>();
		}

		[Benchmark]
		public static void BenchmarkMatrixClass()
		{
			Matrix_Class MatrixClass = new Matrix_Class(1, 2, 3, 4, 5, 6, 7, 8, 9);
			PrintFirstItem_Class(MatrixClass);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PrintFirstItem_Class(Matrix_Class matrix_Class)
		 => Debug.WriteLine(matrix_Class.i00);


		[Benchmark]
		public static void BenchmarkMatrixStructByRef()
		{
			Matrix_Struct MatrixStruct = new Matrix_Struct(1, 2, 3, 4, 5, 6, 7, 8, 9);
			PrintFirstItem_Struct_Ref(ref MatrixStruct);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PrintFirstItem_Struct_Ref(ref Matrix_Struct matrix_Struct)
		 => Debug.WriteLine(matrix_Struct.i00);

		public static void PrintFirstItem_Struct(Matrix_Struct matrix_Struct)
		 => Debug.WriteLine(matrix_Struct.i00);
	}
}
