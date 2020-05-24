using NUnit.Framework;

namespace SockMerchant
{
    public class SolutionTest
    {
        [TestCase(new[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 }, 3)]
        public void Test(int[] socks, int expected)
        {
            var actual = Solution.SockMerchant(socks);

            Assert.AreEqual(expected, actual);
        }
    }
}
