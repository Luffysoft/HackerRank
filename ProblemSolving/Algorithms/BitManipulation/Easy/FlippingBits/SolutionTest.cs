using NUnit.Framework;

namespace FlippingBits
{
    public class SolutionTest
    {
        [TestCase(9, 4294967286)]
        [TestCase(2147483647, 2147483648)]
        [TestCase(1, 4294967294)]
        [TestCase(0, 4294967295)]
        [TestCase(4, 4294967291)]
        [TestCase(123456, 4294843839)]
        [TestCase(802743475, 3492223820)]
        [TestCase(35601423, 4259365872)]
        public void Test(long n, long expected)
        {
            var actual = Solution.FlippingBits(n);

            Assert.AreEqual(expected, actual);
        }
    }
}
