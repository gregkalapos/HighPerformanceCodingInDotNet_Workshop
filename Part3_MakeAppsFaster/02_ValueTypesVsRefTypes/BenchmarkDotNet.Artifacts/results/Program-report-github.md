``` ini

BenchmarkDotNet=v0.10.9, OS=Windows 10 Redstone 2 (10.0.15063)
Processor=Intel Core i7-6700 CPU 3.40GHz (Skylake), ProcessorCount=8
Frequency=3328124 Hz, Resolution=300.4696 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
 |                           Method |     Mean |     Error |    StdDev |      Gen 0 |     Gen 1 |     Gen 2 | Allocated |
 |--------------------------------- |---------:|----------:|----------:|-----------:|----------:|----------:|----------:|
 |                      ManyClasses | 95.16 ms | 1.8801 ms | 2.5098 ms |  4945.3125 | 2814.4531 | 1599.6094 |  38.89 MB |
 |           ManyStructs_NoOverLoad | 51.08 ms | 1.1323 ms | 1.5499 ms | 12625.0000 | 1187.5000 | 1187.5000 |  61.78 MB |
 | ManyStructs_ProperImplementation | 23.44 ms | 0.1045 ms | 0.0977 ms |   744.6121 |  744.6121 |  744.6121 |     16 MB |
