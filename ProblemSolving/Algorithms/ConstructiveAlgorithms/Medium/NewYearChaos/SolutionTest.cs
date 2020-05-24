using NUnit.Framework;

namespace NewYearChaos
{
    public class SolutionTest
    {
        [TestCase(new[] { 2, 1, 5, 3, 4 }, 3)]
        [TestCase(new[] { 2, 1, 5, 4, 3 }, 4)]
        [TestCase(new[] { 2, 5, 1, 3, 4 }, null)]
        [TestCase(new[] { 5, 1, 2, 3, 7, 8, 6, 4 }, null)]
        [TestCase(new[] { 1, 2, 5, 3, 7, 8, 6, 4 }, 7)]
        public void Test(int[] q, int? expected)
        {
            var actual = Solution.MinimumBribesWithResult(q);

            Assert.AreEqual(expected, actual);
        }
    }
}
