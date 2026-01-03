using BenchmarkDotNet.Running;

using Permutations.Performance.Tests;

internal class Program
{
    static void Main()
    {
        _ = BenchmarkRunner.Run<PermutationsTests>();
    }
}