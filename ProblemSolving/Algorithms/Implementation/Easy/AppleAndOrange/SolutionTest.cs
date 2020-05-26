using NUnit.Framework;

namespace AppleAndOrange
{
    public class SolutionTest
    {
        [TestCase(7, 10, 4, 12, new [] { 2, 3, -4 }, new [] { 3, -2, -4 } , new [] { 1, 2 })]
        [TestCase(7, 11, 5, 15, new[] { -2, 2, 1 }, new[] { 5, -6 }, new[] { 1, 1 })]
        public void Test(int s, int t, int a, int b, int[] apples, int[] oranges, int[] expected)
        {
            var actual = Solution.CountApplesAndOrangesWithResult(s, t, a, b, apples, oranges);

            Assert.AreEqual(expected, actual);
        }
    }
}
