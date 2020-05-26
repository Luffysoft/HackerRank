using NUnit.Framework;

namespace Day03_IntroToConditionalStatements
{
    public class SolutionTest
    {
        [TestCase(7L, true)]
        [TestCase(3L, true)]
        [TestCase(24L, false)]
        [TestCase(18L, true)]

        public void Test(double number, bool expected)
        {
            var actual = Solution.IsWeirdWithResult(number);

            Assert.AreEqual(expected, actual);
        }
    }
}
