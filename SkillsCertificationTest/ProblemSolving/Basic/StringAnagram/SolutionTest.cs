using System.Collections.Generic;
using NUnit.Framework;

namespace StringAnagram
{
    public class SolutionTest
    {
        private static IEnumerable<(List<string> dictionary, List<string> queries, List<int> expected)> Scenarios()
        {
            yield return
            (
                new List<string>
                {
                    "hack", "a", "rank", "khac", "ackh", "kran", "rankhacker", "a", "ab", "ba", "stairs", "raits"
                },
                new List<string>
                {
                    "a", "nark", "bs", "hack", "stair"
                },
                new List<int>
                {
                    2, 2, 0, 3, 1
                }
            );
        }

        [TestCaseSource(nameof(Scenarios))]
        public void Test((List<string> dictionary, List<string> queries, List<int> expected) scenarios)
        {
            var (dictionary, queries, expected) = scenarios;

            var actual = Solution.StringAnagram(dictionary, queries);

            Assert.AreEqual(expected, actual);
        }
    }
}
