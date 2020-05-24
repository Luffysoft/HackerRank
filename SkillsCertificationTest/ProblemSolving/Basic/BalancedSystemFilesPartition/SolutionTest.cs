using System.Collections.Generic;
using NUnit.Framework;

namespace BalancedSystemFilesPartition
{
    public class SolutionTest
    {
        private static IEnumerable<(List<int>, List<int>, int)> Scenarios()
        {
            yield return
            (
                new List<int>
                {
                    -1, 0, 0, 1, 1, 2
                },
                new List<int>
                {
                    1, 2, 2, 1, 1, 1
                },
                0
            );

            yield return
            (
                new List<int>
                {
                    -1, 0, 1, 2
                },
                new List<int>
                {
                    1, 4, 3, 4
                },
                2
            );

            yield return
            (
                new List<int>
                {
                    -1, 0, 0, 0
                },
                new List<int>
                {
                    10, 11, 10, 10
                },
                19
            );

            yield return
            (
                new List<int>
                {
                    -1, 0, 0, 1, 1, 2, 2
                },
                new List<int>
                {
                    3, 2, 7, 4, 6, 5, 1
                },
                2
            );

            yield return
            (
                new List<int>
                {
                    -1, 0, 0, 0, 1, 1, 3, 3, 3, 3, 5
                },
                new List<int>
                {
                    3, 2, 9, 7, 1, 8, 1, 4, 0, 5, 2
                },
                8
            );
        }

        [TestCaseSource(nameof(Scenarios))]
        public void Test((List<int>, List<int>, int) scenarios)
        {
            var (parents, sizes, expected) = scenarios;

            var actual = Solution.MostBalancedPartition(parents, sizes);

            Assert.AreEqual(expected, actual);
        }
    }
}
