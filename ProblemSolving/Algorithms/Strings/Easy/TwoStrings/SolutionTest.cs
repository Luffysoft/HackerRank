using NUnit.Framework;

namespace TwoStrings
{
    public class SolutionTest
    {
        [TestCase("hello", "world", "YES")]
        [TestCase("hi", "world", "NO")]
        public void Test(string s1, string s2, string expected)
        {
            var actual = Solution.TwoStrings(s1, s2);

            Assert.AreEqual(expected, actual);
        }
    }
}
