using NUnit.Framework;

namespace MinimumSwaps2
{
    public class SolutionTest
    {
        [TestCase(new[] { 7, 1, 3, 2, 4, 5, 6 }, 5)]
        [TestCase(new[] { 4, 3, 1, 2 }, 3)]
        [TestCase(new[] { 2, 3, 4, 1, 5 }, 3)]
        [TestCase(new[] { 1, 3, 5, 2, 4, 6, 7 }, 3)]
        public void Test(int[] arr, int expected)
        {
            var actual = Solution.MinimumSwaps(arr);

            Assert.AreEqual(expected, actual);
        }
    }
}
