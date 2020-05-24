using NUnit.Framework;

namespace SimpleArraySum
{
    public class SolutionTest
    {
        [TestCase(new[] { 1, 2, 3, 4, 10, 11 }, 31)]
        public void Test(int[] ar, int expected)
        {
            var actual = Solution.SimpleArraySum(ar);

            Assert.AreEqual(expected, actual);
        }
    }
}
