namespace Permutations.Tests;

using System.Collections.Generic;

using NUnit.Framework;

[TestFixture]
internal class PermutationsTests
{
    [Test]
    public void Get_EmptyList_ReturnsEmptyList()
    {
        IEnumerable<IEnumerable<int>> result = Permutations.Get(new List<int>());

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Get_SingleElementList_ReturnsSinglePermutation()
    {
        IEnumerable<IEnumerable<int>> result = Permutations.Get([1]);

        Assert.That(result, Is.EqualTo(new List<IEnumerable<int>> { new List<int> { 1 } }));
    }

    [Test]
    public void Get_TwoElementList_ReturnsTwoPermutations()
    {
        IEnumerable<IEnumerable<int>> result = Permutations.Get([1, 2]);

        Assert.That(result, Is.EquivalentTo(new List<IEnumerable<int>>
        {
            new List<int> { 1, 2 },
            new List<int> { 2, 1 }
        }));
    }

    [Test]
    public void Get_NullList_ReturnsEmptyList()
    {
        IEnumerable<IEnumerable<int>> result = Permutations.Get((IEnumerable<int>)null!);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void GetSingleList_EmptyList_ReturnsEmptyList()
    {
        IEnumerable<int> result = Permutations.GetSingleList(new List<int>());

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void GetSingleList_SingleElementList_ReturnsSinglePermutation()
    {
        IEnumerable<int> result = Permutations.GetSingleList([1]);

        Assert.That(result, Is.EqualTo(new List<int> { 1 }));
    }

    [Test]
    public void GetSingleList_TwoElementList_ReturnsTwoPermutations()
    {
        IEnumerable<int> result = Permutations.GetSingleList([1, 2]);

        Assert.That(result, Is.EqualTo(new List<int> { 1, 2, 2, 1 }));
    }

    [Test]
    public void GetSingleList_NullList_ReturnsEmptyList()
    {
        IEnumerable<int> result = Permutations.GetSingleList((IEnumerable<int>)null!);

        Assert.That(result, Is.Empty);
    }
}
