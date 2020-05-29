using NUnit.Framework;

namespace DavisStaircase
{
    public class SolutionTest
    {
        [TestCase(1, 1)]
        [TestCase(3, 4)]
        [TestCase(5, 13)]
        [TestCase(7, 44)]
        [TestCase(20, 121415)]
        [TestCase(30, 53798080)]
        [TestCase(33, 334745777)]
        [TestCase(35, 1132436852)]
        [TestCase(36, 2082876103)]
        public void Test2(int n, int expected)
        {
            var actual = Solution.StepPerms(n);

            Assert.AreEqual(expected, actual);
        }
    }
}
