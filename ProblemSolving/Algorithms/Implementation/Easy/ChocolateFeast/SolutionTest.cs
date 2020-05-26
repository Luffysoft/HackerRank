using NUnit.Framework;

namespace ChocolateFeast
{
    public class SolutionTest
    {
        [TestCase(15, 3, 2, 9)]
        [TestCase(10, 2, 5, 6)]
        [TestCase(12, 4, 4, 3)]
        [TestCase(6, 2, 2, 5)]
        public void Test(int n, int c, int m, int expected)
        {
            var actual = Solution.ChocolateFeast(n, c, m);

            Assert.AreEqual(expected, actual);
        }
    }
}
