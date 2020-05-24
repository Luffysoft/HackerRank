using NUnit.Framework;

namespace MarkAndToys
{
    public class SolutionTest
    {
        [TestCase(new[] { 1, 2, 3, 4 }, 7, 3)]
        [TestCase(new[] { 1, 12, 5, 111, 200, 1000, 10 }, 50, 4)]
        public void Test(int[] prices, int k, int expected)
        {
            var actual = Solution.MaximumToys(prices, k);

            Assert.AreEqual(expected, actual);
        }
    }
}
