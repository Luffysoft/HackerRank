using NUnit.Framework;

namespace Day01_DataTypes
{
    public class SolutionTest
    {
        [TestCase("12", "4.0", "is the best place to learn and practice coding!")]
        public void Test(string i0, string d0, string s0)
        {
            Solution.Print(i0, d0, s0);

            Assert.Pass();
        }
    }
}
