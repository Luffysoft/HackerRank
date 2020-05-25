using System.Collections.Generic;
using NUnit.Framework;

namespace ATaleOfTwoStacks
{
    public class SolutionTest
    {
        private static IEnumerable<(List<List<int>> queries, List<int> expected)> Scenarios()
        {
            yield return
            (
                new List<List<int>>
                {
                    new List<int> { 1, 35 },
                    new List<int> { 1, 15 },
                    new List<int> { 3 },
                    new List<int> { 2 },
                    new List<int> { 3 }
                },
                new List<int> { 35, 15 }
            );

            yield return
            (
                new List<List<int>>
                {
                    new List<int> { 1, 42 },
                    new List<int> { 2 },
                    new List<int> { 1, 14 },
                    new List<int> { 3 },
                    new List<int> { 1, 28 },
                    new List<int> { 3 },
                    new List<int> { 1, 60 },
                    new List<int> { 1, 78 },
                    new List<int> { 2 },
                    new List<int> { 2 }
                },
                new List<int> { 14, 14 }
            );
        }

        [TestCaseSource(nameof(Scenarios))]
        public void Test((List<List<int>> queries, List<int> expected) scenarios)
        {
            var (queries, expected) = scenarios;

            var actual = Solution.ProcessQueries(queries);

            Assert.AreEqual(expected, actual);
        }
    }
}
