# Permutations.PerformanceTests

> [!WARNING]
> Work in progress...

Using [Benchmarkdotnet](https://benchmarkdotnet.org/); once the project has compiled call `Permutations.PerformanceTests.exe` outside of Visual Studio (for better performance results).

## Results
```

BenchmarkDotNet v0.15.0, Windows 11 (10.0.26100.4061/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.204
  [Host]     : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                                          | Mean      | Error     | StdDev    | Ratio | RatioSD |
|------------------------------------------------ |----------:|----------:|----------:|------:|--------:|
| GetPermutations_With10_000CyclesOfInt           | 22.446 ns | 0.4615 ns | 0.6161 ns |  1.00 |    0.04 |
| GetPermutationsSingleList_With10_000CyclesOfInt |  4.021 ns | 0.0991 ns | 0.1513 ns |  0.18 |    0.01 |
