using NUnit.Framework;

namespace MakingAnagrams
{
    public class Tests
    {
        [TestCase("cde", "dcf", 2)]
        [TestCase("cde", "abc", 4)]
        public void Test(string a, string b, int expected)
        {
            var actual = Solution.MakingAnagrams(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("cde", "dcf", 2)]
        [TestCase("cde", "abc", 4)]
        public void Test2(string a, string b, int expected)
        {
            var actual = Solution.MakingAnagramsV2(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
