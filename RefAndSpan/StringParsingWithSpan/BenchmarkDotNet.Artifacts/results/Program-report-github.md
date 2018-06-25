``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i5-5200U CPU 2.20GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.1.300
  [Host]     : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT


```
|         Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
|--------------- |---------:|----------:|----------:|-------:|----------:|
| WorkWithString | 497.8 ns | 1.5129 ns | 1.2633 ns | 0.8183 |    1288 B |
|   WorkWithSpan | 222.3 ns | 0.5075 ns | 0.4238 ns |      - |       0 B |
