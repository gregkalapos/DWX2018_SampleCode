``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i5-5200U CPU 2.20GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.1.300
  [Host]     : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT


```
|                Method |      Mean |     Error |    StdDev |
|---------------------- |----------:|----------:|----------:|
|  BenchmarkMatrixClass |  9.315 ns | 0.0346 ns | 0.0307 ns |
| BenchmarkMatrixStruct | 11.929 ns | 0.0116 ns | 0.0097 ns |
