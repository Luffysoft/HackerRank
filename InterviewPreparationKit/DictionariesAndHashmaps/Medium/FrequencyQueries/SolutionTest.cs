using System.Collections.Generic;
using NUnit.Framework;

namespace FrequencyQueries
{
    public class SolutionTest
    {
        private static IEnumerable<(List<List<int>>, List<int>)> Scenarios()
        {
            yield return
            (
                new List<List<int>>
                {
                    new List<int> { 1, 1 },
                    new List<int> { 2, 2 },
                    new List<int> { 3, 2 },
                    new List<int> { 1, 1 },
                    new List<int> { 1, 1 },
                    new List<int> { 2, 1 },
                    new List<int> { 3, 2 }
                },
                new List<int> { 0, 1 }
            );

            yield return
            (
                new List<List<int>>
                {
                    new List<int> { 1, 5 },
                    new List<int> { 1, 6 },
                    new List<int> { 3, 2 },
                    new List<int> { 1, 10 },
                    new List<int> { 1, 10 },
                    new List<int> { 1, 6 },
                    new List<int> { 2, 5 },
                    new List<int> { 3, 2 }
                },
                new List<int> { 0, 1 }
            );

            yield return
            (
                new List<List<int>>
                {
                    new List<int> { 3, 4 },
                    new List<int> { 2, 1003 },
                    new List<int> { 1, 16 },
                    new List<int> { 3, 1 }
                },
                new List<int> { 0, 1 }
            );

            yield return
            (
                new List<List<int>>
                {
                    new List<int> { 1, 3 },
                    new List<int> { 2, 3 },
                    new List<int> { 3, 2 },
                    new List<int> { 1, 4 },
                    new List<int> { 1, 5 },
                    new List<int> { 1, 5 },
                    new List<int> { 1, 4 },
                    new List<int> { 3, 2 },
                    new List<int> { 2, 4 },
                    new List<int> { 3, 2 }
                },
                new List<int> { 0, 1, 1 }
            );
        }

        [TestCaseSource(nameof(Scenarios))]
        public void Test((List<List<int>>, List<int>) scenarios)
        {
            var (queries, expected) = scenarios;

            var actual = Solution.FreqQuery(queries);

            Assert.AreEqual(expected, actual);
        }
    }
}
