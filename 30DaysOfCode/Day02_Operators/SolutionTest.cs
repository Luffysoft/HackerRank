using NUnit.Framework;

namespace Day02_Operators
{
    public class SolutionTest
    {
        [TestCase(12, 20, 8, 15)]

        public void Test(double mealCost, int tipPercent, int taxPercent, int expected)
        {
            var actual = Solution.SolveWithResult(mealCost, tipPercent, taxPercent);

            Assert.AreEqual(expected, actual);
        }
    }
}
