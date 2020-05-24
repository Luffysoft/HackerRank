using NUnit.Framework;

namespace Day00_HelloWorld
{
    public class SolutionTest
    {
        [TestCase("Welcome to 30 Days of Code!")]
        public void Test(string inputString)
        {
            Solution.Print(inputString);

            Assert.Pass();
        }
    }
}
