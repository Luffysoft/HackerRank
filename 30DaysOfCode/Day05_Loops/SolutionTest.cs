using System.Collections.Generic;
using NUnit.Framework;

namespace Day05_Loops
{
    public class SolutionTest
    {
        private static IEnumerable<(int n, IEnumerable<(int i, int n, int m)> expected)> Scenarios()
        {
            yield return
            (
                2,
                new List<(int i, int n, int m)>
                {
                    (1, 2, 2),
                    (2, 2, 4),
                    (3, 2, 6),
                    (4, 2, 8),
                    (5, 2, 10),
                    (6, 2, 12),
                    (7, 2, 14),
                    (8, 2, 16),
                    (9, 2, 18),
                    (10, 2, 20),
                }
            );

            yield return
            (
                7,
                new List<(int i, int n, int m)>
                {
                    (1, 7, 7),
                    (2, 7, 14),
                    (3, 7, 21),
                    (4, 7, 28),
                    (5, 7, 35),
                    (6, 7, 42),
                    (7, 7, 49),
                    (8, 7, 56),
                    (9, 7, 63),
                    (10, 7, 70),
                }
            );
        }

        [TestCaseSource(nameof(Scenarios))]
        public void Test((int n, IEnumerable<(int i, int n, int m)> expected) scenarios)
        {
            var (n, expected) = scenarios;

            var actual = Solution.MultiplyTableWithResult(n);

            Assert.AreEqual(expected, actual);
        }
    }
}
