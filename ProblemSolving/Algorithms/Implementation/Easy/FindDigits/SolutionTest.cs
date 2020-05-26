using NUnit.Framework;

namespace FindDigits
{
    public class SolutionTest
    {
        [TestCase(12, 2)]
        [TestCase(1012, 3)]
        [TestCase(123456789, 3)]
        public void Test(int number, int expected)
        {
            var actual = Solution.FindDigits(number);

            Assert.AreEqual(expected, actual);
        }
    }
}
