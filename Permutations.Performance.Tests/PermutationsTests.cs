namespace Permutations.Performance.Tests;

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
    public void Get_With10_000CyclesOfInt()
    {
        _ = Permutations.Get(inputs);
    }

    [Benchmark]
    public void GetSingleList_With10_000CyclesOfInt()
    {
        _ = Permutations.GetSingleList(inputs);
    }
}
