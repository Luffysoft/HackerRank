using System.Collections.Generic;
using NUnit.Framework;

namespace NiceTeams
{
    public class SolutionTest
    {
        private static IEnumerable<(List<int>, int, int)> Scenarios()
        {
            yield return
            (
                new List<int> { 1, 1, 1, 1 },
                1,
                0
            );

            yield return
            (
                new List<int> { 3, 4, 5, 2, 1, 1 },
                3,
                2
            );
        }

        [TestCaseSource(nameof(Scenarios))]
        public void Test((List<int>, int, int) scenarios)
        {
            var (skillLevel, minDiff, expected) = scenarios;

            var actual = Solution.MaxPairs(skillLevel, minDiff);

            Assert.AreEqual(expected, actual);
        }
    }
}
