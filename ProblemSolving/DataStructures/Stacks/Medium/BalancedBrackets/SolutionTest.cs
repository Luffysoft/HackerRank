using NUnit.Framework;

namespace BalancedBrackets
{
    public class SolutionTest
    {
        [TestCase("{[(])}", "NO")]
        [TestCase("{[()]}", "YES")]
        [TestCase("{[(])}", "NO")]
        [TestCase("{{[[(())]]}}", "YES")]
        public void Test(string s, string expected)
        {
            var actual = Solution.IsBalanced(s);

            Assert.AreEqual(expected, actual);
        }
    }
}
