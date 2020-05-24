using NUnit.Framework;

namespace AlternatingCharacters
{
    public class SolutionTest
    {
        [TestCase("AABAAB", 2)]
        [TestCase("AAAA", 3)]
        [TestCase("BBBBB", 4)]
        [TestCase("ABABABAB", 0)]
        [TestCase("BABABA", 0)]
        [TestCase("AAABBB", 4)]
        public void Test(string s, int expected)
        {
            var actual = Solution.AlternatingCharacters(s);

            Assert.AreEqual(expected, actual);
        }
    }
}
