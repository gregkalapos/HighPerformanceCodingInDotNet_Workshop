``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 2 [1703, Creators Update] (10.0.15063.909)
Intel Core i7-6700 CPU 3.40GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3328124 Hz, Resolution=300.4696 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|               Method |      Mean |     Error |    StdDev |      Gen 0 |    Gen 1 |    Gen 2 | Allocated |
|--------------------- |----------:|----------:|----------:|-----------:|---------:|---------:|----------:|
| CalculateRsiOriginal | 375.19 ms | 7.1971 ms | 6.0099 ms | 59750.0000 | 812.5000 | 375.0000 | 244.33 MB |
|    CalculateRsiFixed |  24.91 ms | 0.5810 ms | 0.5435 ms |  1875.0000 | 406.2500 | 156.2500 |   8.93 MB |
