``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i5-5200U CPU 2.20GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.1.300
  [Host] : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT
  Clr    : .NET Framework 4.7.1 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3110.0
  Core   : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT


```
|            Method |  Job | Runtime |       Mean |     Error |    StdDev |    Gen 0 |    Gen 1 | Allocated |
|------------------ |----- |-------- |-----------:|----------:|----------:|---------:|---------:|----------:|
| CalculateWithLinq |  Clr |     Clr | 541.506 ms | 2.5407 ms | 2.2523 ms | 875.0000 | 312.5000 |   3.47 MB |
| CalculateWithLinq | Core |    Core |   9.015 ms | 0.1246 ms | 0.1104 ms | 281.2500 |  93.7500 |   1.14 MB |
