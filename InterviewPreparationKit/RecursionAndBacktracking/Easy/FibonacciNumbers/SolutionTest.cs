using NUnit.Framework;

namespace FibonacciNumbers
{
    public class SolutionTest
    {
        [TestCase(3, 2)]
        [TestCase(5, 5)]
        [TestCase(6, 8)]
        public void Test(int n, int expected)
        {
            var actual = Solution.Fibonacci(n);

            Assert.AreEqual(expected, actual);
        }
    }
}
