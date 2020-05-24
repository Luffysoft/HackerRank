using System.Collections.Generic;
using NUnit.Framework;

namespace UserFriendlyPasswordSystem
{
    public class SolutionTest
    {
        private static IEnumerable<(List<List<string>>, List<int>)> Scenarios()
        {
            yield return
            (
                new List<List<string>>
                {
                    new List<string> { "setPassword", "000A" },
                    new List<string> { "authorize", "108738450" },
                    new List<string> { "authorize", "108738449" },
                    new List<string> { "authorize", "244736787" }
                },
                new List<int> { 0, 1, 1 }
            );

            yield return
            (
                new List<List<string>>
                {
                    new List<string> { "setPassword", "1" },
                    new List<string> { "setPassword", "2" },
                    new List<string> { "setPassword", "3" },
                    new List<string> { "authorize", "49" },
                    new List<string> { "authorize", "50" }
                },
                new List<int> { 0, 0 }
            );
        }

        [TestCaseSource(nameof(Scenarios))]
        public void Test((List<List<string>>, List<int>) scenarios)
        {
            var (events, expected) = scenarios;

            var actual = Solution.AuthEvents(events);

            Assert.AreEqual(expected, actual);
        }
    }
}
