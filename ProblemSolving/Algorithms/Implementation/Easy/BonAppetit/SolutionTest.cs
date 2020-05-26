using System.Collections.Generic;
using NUnit.Framework;

namespace BonAppetit
{
    public class SolutionTest
    {
        private static IEnumerable<(List<int> bill, int k, int b, int? expected)> Scenarios()
        {
            yield return
            (
                new List<int> { 2, 4, 6 },
                2,
                3,
                null
            );

            yield return
            (
                new List<int> { 3, 10, 2, 9 },
                1,
                12,
                5
            );

            yield return
            (
                new List<int> { 3, 10, 2, 9 },
                1,
                7,
                null
            );
        }

        [TestCaseSource(nameof(Scenarios))]
        public void Test((List<int> bill, int k, int b, int? expected) scenarios)
        {
            var (bill, k, b, expected) = scenarios;

            var actual = Solution.BonAppetitWithResult(bill, k, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
