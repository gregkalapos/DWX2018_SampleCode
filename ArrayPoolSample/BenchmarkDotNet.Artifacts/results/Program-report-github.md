``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i5-5200U CPU 2.20GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.1.300
  [Host]     : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT


```
|             Method |         Mean |       Error |      StdDev |       Gen 0 |       Gen 1 |       Gen 2 |    Allocated |
|------------------- |-------------:|------------:|------------:|------------:|------------:|------------:|-------------:|
| ArrayPoolBenchmark |     50.07 us |   0.3495 us |   0.3098 us |           - |           - |           - |          0 B |
|    NoPoolBenchmark | 50,912.28 us | 178.1239 us | 166.6172 us | 333312.5000 | 333312.5000 | 333312.5000 | 1048600000 B |
