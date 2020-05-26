using NUnit.Framework;

namespace PlusMinus
{
    public class SolutionTest
    {
        [TestCase(new [] { 1, 1, 0, -1, -1 }, new [] { .4, .4, .2 })]
        [TestCase(new [] { -4, 3, -9, 0, 4, 1 }, new [] { .5, (double) 1 / 3, (double) 1 / 6 })]
        [TestCase(new [] { 1, -2, -7, 9, 1, -8, -5 }, new [] { (double) 3 / 7, (double) 4 / 7, 0 })]
        public void Test(int[] arr, double[] expected)
        {
            var actual = Solution.PlusMinusWithResult(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 1, 0, -1, -1 }, new[] { .4, .4, .2 })]
        [TestCase(new[] { -4, 3, -9, 0, 4, 1 }, new[] { .5, (double) 1 / 3, (double) 1 / 6 })]
        [TestCase(new[] { 1, -2, -7, 9, 1, -8, -5 }, new[] { (double) 3 / 7, (double) 4 / 7, 0 })]
        public void Test2(int[] arr, double[] expected)
        {
            var actual = Solution.PlusMinusWithResultV2(arr);

            Assert.AreEqual(expected, actual);
        }
    }
}
