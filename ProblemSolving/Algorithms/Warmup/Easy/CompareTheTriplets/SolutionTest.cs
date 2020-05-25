using System.Collections.Generic;
using NUnit.Framework;

namespace CompareTheTriplets
{
    public class SolutionTest
    {
        private static IEnumerable<(List<int> a, List<int> b, List<int> expected)> Scenarios()
        {
            yield return
            (
                new List<int> { 5, 6, 7 },
                new List<int> { 3, 6, 10 },
                new List<int> { 1, 1 }
            );

            yield return
            (
                new List<int> { 17, 28, 30 },
                new List<int> { 99, 16, 8 },
                new List<int> { 2, 1 }
            );
        }

        [TestCaseSource(nameof(Scenarios))]
        public void Test1((List<int> a, List<int> b, List<int> expected) scenarios)
        {
            var (a, b, expected) = scenarios;

            var actual = Solution.CompareTriplets(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
