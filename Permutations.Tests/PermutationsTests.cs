namespace Permutations.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class PermutationsTests
    {
        [Test]
        public void GetPermutations_EmptyList_ReturnsEmptyList()
        {
            IEnumerable<IEnumerable<int>> result = Permutations.GetPermutations(new List<int>());

            Assert.That(result, Is.Empty);
        }

        [Test]
        public void GetPermutations_SingleElementList_ReturnsSinglePermutation()
        {
            IEnumerable<IEnumerable<int>> result = Permutations.GetPermutations([1]);

            Assert.That(result, Is.EqualTo(new List<IEnumerable<int>> { new List<int> { 1 } }));
        }

        [Test]
        public void GetPermutations_TwoElementList_ReturnsTwoPermutations()
        {
            IEnumerable<IEnumerable<int>> result = Permutations.GetPermutations([1, 2]);

            Assert.That(result, Is.EquivalentTo(new List<IEnumerable<int>>
            {
                new List<int> { 1, 2 },
                new List<int> { 2, 1 }
            }));
        }

        [Test]
        public void GetPermutations_NullList_ReturnsEmptyList()
        {
            IEnumerable<IEnumerable<int>> result = Permutations.GetPermutations((IEnumerable<int>)null!);

            Assert.That(result, Is.Empty);
        }

        [Test]
        public void GetPermutationsSingleList_EmptyList_ReturnsEmptyList()
        {
            IEnumerable<int> result = Permutations.GetPermutationsSingleList(new List<int>());

            Assert.That(result, Is.Empty);
        }

        [Test]
        public void GetPermutationsSingleList_SingleElementList_ReturnsSinglePermutation()
        {
            IEnumerable<int> result = Permutations.GetPermutationsSingleList([1]);

            Assert.That(result, Is.EqualTo(new List<int> { 1 }));
        }

        [Test]
        public void GetPermutationsSingleList_TwoElementList_ReturnsTwoPermutations()
        {
            IEnumerable<int> result = Permutations.GetPermutationsSingleList([1, 2]);

            Assert.That(result, Is.EqualTo(new List<int> { 1, 2, 2, 1 }));
        }

        [Test]
        public void GetPermutationsSingleList_NullList_ReturnsEmptyList()
        {
            IEnumerable<int> result = Permutations.GetPermutationsSingleList((IEnumerable<int>)null!);

            Assert.That(result, Is.Empty);
        }
    }
}