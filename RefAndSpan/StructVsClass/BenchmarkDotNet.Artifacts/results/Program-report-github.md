``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i5-5200U CPU 2.20GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.1.300
  [Host]     : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT


```
|                           Method |     Mean |     Error |    StdDev |
|--------------------------------- |---------:|----------:|----------:|
|                      ManyClasses | 2.574 ms | 0.0094 ms | 0.0088 ms |
| ManyStructs_ProperImplementation | 1.376 ms | 0.0044 ms | 0.0041 ms |
