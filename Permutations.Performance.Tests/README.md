# Permutations.PerformanceTests

Using [Benchmarkdotnet](https://benchmarkdotnet.org/); once the project has compiled call `Permutations.Performance.Tests.exe` outside of Visual Studio (for better performance results).

## Results
### 2025-12-19 - `v1.0.2`
```
BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
AMD Ryzen 7 7800X3D 4.20GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
```

| Method                              | Mean      | Error     | StdDev    | Median    | Ratio | RatioSD |
|------------------------------------ |----------:|----------:|----------:|----------:|------:|--------:|
| Get_With10_000CyclesOfInt           | 14.724 ns | 0.3125 ns | 0.5946 ns | 14.272 ns |  1.00 |    0.06 |
| GetSingleList_With10_000CyclesOfInt |  1.022 ns | 0.0112 ns | 0.0094 ns |  1.025 ns |  0.07 |    0.00 |

### 2025-05-22 - `v1.0.1`
```
BenchmarkDotNet v0.15.0, Windows 11 (10.0.26100.4061/24H2/2024Update/HudsonValley)
Unknown processor
.NET SDK 9.0.204
  [Host]     : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
```

| Method                              | Mean      | Error     | StdDev    | Ratio | RatioSD |
|------------------------------------ |----------:|----------:|----------:|------:|--------:|
| Get_With10_000CyclesOfInt           | 22.446 ns | 0.4615 ns | 0.6161 ns |  1.00 |    0.04 |
| GetSingleList_With10_000CyclesOfInt |  4.021 ns | 0.0991 ns | 0.1513 ns |  0.18 |    0.01 |
