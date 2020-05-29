using NUnit.Framework;

namespace Day06_LetSReview
{
    public class SolutionTest
    {
        [TestCase("Hacker", "Hce akr")]
        [TestCase("Rank", "Rn ak")]
        public void Test(string s, string expected)
        {
            var actual = Solution.Solve(s);

            Assert.AreEqual(expected, actual);
        }
    }
}
