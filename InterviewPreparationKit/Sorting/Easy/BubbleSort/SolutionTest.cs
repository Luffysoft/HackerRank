using NUnit.Framework;

namespace BubbleSort
{
    public class SolutionTest
    {
        [TestCase(new[] { 6, 4, 1 }, new[] { 1, 4, 6 })]
        [TestCase(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
        public void Test(int[] a, int[] expected)
        {
            Solution.CountSwaps(a);

            Assert.AreEqual(expected, a);
        }
    }
}
