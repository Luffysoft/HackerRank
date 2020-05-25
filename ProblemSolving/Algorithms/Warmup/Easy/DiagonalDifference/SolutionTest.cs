using System.Collections.Generic;
using NUnit.Framework;

namespace DiagonalDifference
{
    public class SolutionTest
    {
        private static IEnumerable<(int[][] a, int expected)> Scenarios()
        {
            yield return
            (
                new[]
                {
                    new [] { 1, 2, 3 },
                    new [] { 4, 5, 6 },
                    new [] { 9, 8, 9 }
                },
                2
            );

            yield return
            (
                new[]
                {
                    new [] { 11, 2, 4 },
                    new [] { 4, 5, 6 },
                    new [] { 10, 8, - 12 }
                },
                15
            );
        }

        [TestCaseSource(nameof(Scenarios))]
        public void Test((int[][] a, int expected) scenarios)
        {
            var (a, expected) = scenarios;

            var actual = Solution.DiagonalDifference(a);

            Assert.AreEqual(expected, actual);
        }
    }
}
