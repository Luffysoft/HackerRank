using NUnit.Framework;

namespace CountingValleys
{
    public class SolutionTest
    {
        [TestCase("UDDDUDUU", 1)]
        [TestCase("DDUUDDUDUUUD", 2)]
        public void Test(string steps, int expected)
        {
            var actual = Solution.CountingValleys(steps);

            Assert.AreEqual(expected, actual);
        }
    }
}
