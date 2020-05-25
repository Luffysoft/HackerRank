using NUnit.Framework;

namespace SumVsXOR
{
    public class SolutionTest
    {
        [TestCase(4, 4)]
        [TestCase(5, 2)]
        [TestCase(10, 4)]
        public void Test(long n, long expected)
        {
            var actual = Solution.SumXor(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 4)]
        [TestCase(5, 2)]
        [TestCase(10, 4)]
        public void Test2(long n, long expected)
        {
            var actual = Solution.SumXorV2(n);

            Assert.AreEqual(expected, actual);
        }
    }
}
