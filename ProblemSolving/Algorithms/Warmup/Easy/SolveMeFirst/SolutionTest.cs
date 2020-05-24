using NUnit.Framework;

namespace SolveMeFirst
{
    public class SolutionTest
    {
        [TestCase(2, 3, 5)]
        public void Test(int a, int b, int expected)
        {
            var actual = Solution.SolveMeFirst(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
