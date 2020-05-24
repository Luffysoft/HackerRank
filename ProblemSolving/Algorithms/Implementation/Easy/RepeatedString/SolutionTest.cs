using NUnit.Framework;

namespace RepeatedString
{
    public class SolutionTest
    {
        [TestCase("abcac", 10, 4)]
        [TestCase("aba", 10, 7)]
        [TestCase("a", 1000000000000, 1000000000000)]
        [TestCase("kmretasscityylpdhuwjirnqimlkcgxubxmsxpypgzxtenweirknjtasxtvxemtwxuarabssvqdnktqadhyktagjxoanknhgilnm", 736778906400, 51574523448)]
        public void Test(string message, long n, long expected)
        {
            var actual = Solution.RepeatedString(message, n);

            Assert.AreEqual(expected, actual);
        }
    }
}
