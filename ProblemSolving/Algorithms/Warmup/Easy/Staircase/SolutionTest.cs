using System.Collections.Generic;
using NUnit.Framework;

namespace Staircase
{
    public class SolutionTest
    {
        private static IEnumerable<(int n, IEnumerable<IEnumerable<char>> expected)> Scenarios()
        {
            yield return
            (
                4,
                new List<List<char>>
                {
                    new List<char> { ' ', ' ', ' ', '#' },
                    new List<char> { ' ', ' ', '#', '#' },
                    new List<char> { ' ', '#', '#', '#' },
                    new List<char> { '#', '#', '#', '#' }
                }
            );

            yield return
            (
                6,
                new List<List<char>>
                {
                    new List<char> { ' ', ' ', ' ', ' ', ' ', '#' },
                    new List<char> { ' ', ' ', ' ', ' ', '#', '#' },
                    new List<char> { ' ', ' ', ' ', '#', '#', '#' },
                    new List<char> { ' ', ' ', '#', '#', '#', '#' },
                    new List<char> { ' ', '#', '#', '#', '#', '#' },
                    new List<char> { '#', '#', '#', '#', '#', '#' },
                }
            );
        }

        [TestCaseSource(nameof(Scenarios))]
        public void Test((int n, IEnumerable<IEnumerable<char>> expected) scenarios)
        {
            var (n, expected) = scenarios;

            var actual = Solution.StaircaseWithResult(n);

            Assert.AreEqual(expected, actual);
        }
    }
}
