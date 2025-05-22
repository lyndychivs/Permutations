using BenchmarkDotNet.Running;

using Permutations.PerformanceTests;

internal class Program
{
    static void Main()
    {
        _ = BenchmarkRunner.Run<PermutationsTests>();
    }
}