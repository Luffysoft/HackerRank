using NUnit.Framework;

namespace Day07_Arrays
{
    public class SolutionTest
    {
        [TestCase(new [] { 1, 4, 3, 2 }, new [] { 1, 4, 3, 2 })]
        public void Test(int[] arr, int[] expected)
        {
            Solution.Solve(arr);
            var actual = Solution.SolveWithResult(arr);

            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}
