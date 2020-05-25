using NUnit.Framework;

namespace MaximizingXOR
{
    public class SolutionTest
    {
        [TestCase(11, 12, 7)]
        [TestCase(10, 15, 7)]
        [TestCase(11, 100, 127)]
        [TestCase(72, 100, 63)]
        public void Test(int l, int r, int expected)
        {
            var actual = Solution.MaximizingXor(l, r);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(11, 12, 7)]
        [TestCase(10, 15, 7)]
        [TestCase(11, 100, 127)]
        [TestCase(72, 100, 63)]
        public void Test2(int l, int r, int expected)
        {
            var actual = Solution.MaximizingXorV2(l, r);

            Assert.AreEqual(expected, actual);
        }
    }
}
