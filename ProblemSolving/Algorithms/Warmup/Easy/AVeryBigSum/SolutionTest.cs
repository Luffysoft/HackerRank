using NUnit.Framework;

namespace AVeryBigSum
{
    public class SolutionTest
    {
        [TestCase(new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 }, 5000000015)]
        public void Test(long[] ar, long expected)
        {
            var actual = Solution.AVeryBigSum(ar);

            Assert.AreEqual(expected, actual);
        }
    }
}
