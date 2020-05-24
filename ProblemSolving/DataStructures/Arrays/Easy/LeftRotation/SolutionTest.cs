using NUnit.Framework;

namespace LeftRotation
{
    public class SolutionTest
    {
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 2, new[] { 3, 4, 5, 1, 2 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 4, new[] { 5, 1, 2, 3, 4 })]
        [TestCase(new[] { 41, 73, 89, 7, 10, 1, 59, 58, 84, 77, 77, 97, 58, 1, 86, 58, 26, 10, 86, 51 }, 10, new[] { 77, 97, 58, 1, 86, 58, 26, 10, 86, 51, 41, 73, 89, 7, 10, 1, 59, 58, 84, 77 })]
        public void Test(int[] a, int d, int[] expected)
        {
            var actual = Solution.RotLeftWithResult(a, d);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3, 4, 5 }, 2, "3 4 5 1 2")]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 4, "5 1 2 3 4")]
        [TestCase(new[] { 41, 73, 89, 7, 10, 1, 59, 58, 84, 77, 77, 97, 58, 1, 86, 58, 26, 10, 86, 51 }, 10, "77 97 58 1 86 58 26 10 86 51 41 73 89 7 10 1 59 58 84 77")]
        public void Test2(int[] a, int d, string expected)
        {
            var actual = Solution.RotLeftWithStringResult(a, d);

            Assert.AreEqual(expected, actual);
        }
    }
}
