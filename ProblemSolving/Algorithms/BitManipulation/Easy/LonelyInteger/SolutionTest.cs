using NUnit.Framework;

namespace LonelyInteger
{
    public class SolutionTest
    {
        [TestCase(new [] { 1, 2, 3, 4, 3, 2, 1 }, 4)]
        [TestCase(new [] { 1 }, 1)]
        [TestCase(new [] { 1, 1, 2 }, 2)]
        [TestCase(new [] { 0, 0, 1, 2, 1 }, 2)]
        public void Test(int[] a, int expected)
        {
            var actual = Solution.Lonelyinteger(a);

            Assert.AreEqual(expected, actual);
        }
    }
}
