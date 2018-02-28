``` ini

BenchmarkDotNet=v0.10.9, OS=Windows 10 Redstone 2 (10.0.15063)
Processor=Intel Core i7-6700 CPU 3.40GHz (Skylake), ProcessorCount=8
Frequency=3328124 Hz, Resolution=300.4696 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
 |                              Method |       Mean |     Error |    StdDev |
 |------------------------------------ |-----------:|----------:|----------:|
 |       CheckForNonExistingItemInList |   610.6 us |  6.591 us |  5.842 us |
 | CheckForNonExistingItemInLinkedList | 3,851.4 us | 42.265 us | 35.293 us |
