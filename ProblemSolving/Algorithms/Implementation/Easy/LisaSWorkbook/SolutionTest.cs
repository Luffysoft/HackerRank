using NUnit.Framework;

namespace LisaSWorkbook
{
    public class SolutionTest
    {
        [TestCase(3, new [] { 4, 2, 6, 1, 10 }, 4)]
        public void Test(int k, int[] arr, int expected)
        {
            var actual = Solution.Workbook(k, arr);

            Assert.AreEqual(expected, actual);
        }
    }
}
