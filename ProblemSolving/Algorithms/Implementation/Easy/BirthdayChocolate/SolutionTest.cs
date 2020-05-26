using System.Collections.Generic;
using NUnit.Framework;

namespace BirthdayChocolate
{
    public class SolutionTest
    {
        private static IEnumerable<(List<int> s, int d, int m, int expected)> Scenarios()
        {
            yield return
            (
                new List<int> { 2, 2, 1, 3, 2 },
                4,
                2,
                2
            );

            yield return
            (
                new List<int> { 1, 2, 1, 3, 2 },
                3,
                2,
                2
            );

            yield return
            (
                new List<int> { 1, 1, 1, 1, 1, 1 },
                3,
                2,
                0
            );

            yield return
            (
                new List<int> { 4 },
                4,
                1,
                1
            );
        }

        [TestCaseSource(nameof(Scenarios))]
        public void Test((List<int> s, int d, int m, int expected) scenarios)
        {
            var (s, d, m, expected) = scenarios;

            var actual = Solution.Birthday(s, d, m);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(Scenarios))]
        public void Test2((List<int> s, int d, int m, int expected) scenarios)
        {
            var (s, d, m, expected) = scenarios;

            var actual = Solution.BirthdayV2(s, d, m);

            Assert.AreEqual(expected, actual);
        }
    }
}
