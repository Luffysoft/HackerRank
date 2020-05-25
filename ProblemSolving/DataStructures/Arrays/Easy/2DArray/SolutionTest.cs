using System.Collections.Generic;
using NUnit.Framework;

namespace _2DArray
{
    public class SolutionTest
    {
        private static IEnumerable<(int[][] arr, int expected)> Scenarios()
        {
            yield return
            (
                new[]
                {
                    new [] { 1, 1, 1, 0, 0, 0 },
                    new [] { 0, 1, 0, 0, 0, 0 },
                    new [] { 1, 1, 1, 0, 0, 0 },
                    new [] { 0, 0, 0, 0, 0, 0 },
                    new [] { 0, 0, 0, 0, 0, 0 },
                    new [] { 0, 0, 0, 0, 0, 0 }
                },
                7
            );

            yield return
            (
                new[]
                {
                    new [] { -9, -9, -9,  1, 1, 1 },
                    new [] { 0, -9,  0,  4, 3, 2 },
                    new [] { -9, -9, -9,  1, 2, 3 },
                    new [] { 0, 0,  8,  6, 6, 0 },
                    new [] { 0, 0, 0, -2, 0, 0 },
                    new [] { 0, 0, 1, 2, 4, 0 }
                },
                28
            );
        }

        [TestCaseSource(nameof(Scenarios))]
        public void Test((int[][] arr, int expected) scenarios)
        {
            var (arr, expected) = scenarios;

            var actual = Solution.HourglassSum(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(Scenarios))]
        public void Test2((int[][] arr, int expected) scenarios)
        {
            var (arr, expected) = scenarios;

            var actual = Solution.HourglassSumV2(arr);

            Assert.AreEqual(expected, actual);
        }
    }
}
