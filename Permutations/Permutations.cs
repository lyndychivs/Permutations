namespace Permutations
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A class that provides a method to generate all permutations of a given collection.
    /// </summary>
    public static class Permutations
    {
        /// <summary>
        /// Generates all permutations of the given enumerable collection.
        /// </summary>
        /// <typeparam name="T">The type of the elements in the input collection.</typeparam>
        /// <param name="enumerables">The input collection to generate permutations from.</param>
        /// <returns>
        /// An <see cref="IEnumerable{T}"/> of <see cref="IEnumerable{T}"/> containing all possible permutations of the input collection.
        /// If the input is null or empty, returns an empty sequence.
        /// </returns>
        public static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> enumerables)
        {
            if (enumerables == null || !enumerables.Any())
            {
                return Enumerable.Empty<IEnumerable<T>>();
            }

            if (enumerables.Count() == 1)
            {
                return enumerables.Select(t => new T[] { t });
            }

            return enumerables.SelectMany(t => GetPermutations(enumerables.Where(e => !e.Equals(t))),
                (t1, t2) => new T[] { t1 }.Concat(t2));
        }

        /// <summary>
        /// Generates all permutations of the given enumerable collection and returns them as a single list.<br/>
        /// WARNING: This method may not be pratical for all use-cases as it returns a single list of all permutations, with no way to distinguish between them.
        /// </summary>
        /// <typeparam name="T">The type of the elements in the input collection.</typeparam>
        /// <param name="enumerables">The input collection to generate permutations from.</param>
        /// <returns>
        /// An <see cref="IEnumerable{T}"/>  containing all possible permutations of the input collection.
        /// If the input is null or empty, returns an empty sequence.
        /// </returns>
        public static IEnumerable<T> GetPermutationsSingleList<T>(IEnumerable<T> enumerables)
        {
            IEnumerable<IEnumerable<T>> permutations = GetPermutations(enumerables);

            foreach (IEnumerable<T> permutation in permutations)
            {
                foreach (T type in permutation)
                {
                    yield return type;
                }
            }
        }
    }
}