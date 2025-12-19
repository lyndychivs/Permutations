namespace Permutations.PerformanceTests;

using BenchmarkDotNet.Attributes;

public class PermutationsTests
{
    private readonly int[] inputs;

    public PermutationsTests()
    {
        inputs = new int[10_000];
        for (int i = 0; i < inputs.Length; i++)
        {
            inputs[i] = i;
        }
    }

    [Benchmark(Baseline = true)]
    public void GetPermutations_With10_000CyclesOfInt()
    {
        _ = Permutations.GetPermutations(inputs);
    }

    [Benchmark]
    public void GetPermutationsSingleList_With10_000CyclesOfInt()
    {
        _ = Permutations.GetPermutationsSingleList(inputs);
    }
}