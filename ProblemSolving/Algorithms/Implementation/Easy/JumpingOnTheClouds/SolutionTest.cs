using NUnit.Framework;

namespace JumpingOnTheClouds
{
    public class SolutionTest
    {
        [TestCase(new[] { 0, 1, 0, 0, 0, 1, 0 }, 3)]
        [TestCase(new[] { 0, 0, 1, 0, 0, 1, 0 }, 4)]
        [TestCase(new[] { 0, 0, 0, 0, 1, 0 }, 3)]
        public void Test(int[] clouds, int expected)
        {
            var actual = Solution.JumpingOnClouds(clouds);

            Assert.AreEqual(expected, actual);
        }
    }
}
