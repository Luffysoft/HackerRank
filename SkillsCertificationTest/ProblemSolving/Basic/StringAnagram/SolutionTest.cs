using System.Collections.Generic;
using NUnit.Framework;

namespace StringAnagram
{
    public class SolutionTest
    {
        private static IEnumerable<(List<string>, List<string>, List<int>)> Scenarios()
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
        public void Test((List<string>, List<string>, List<int>) scenarios)
        {
            var (dictionary, query, expected) = scenarios;

            var actual = Solution.StringAnagram(dictionary, query);

            Assert.AreEqual(expected, actual);
        }
    }
}
