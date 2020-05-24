using System;
using System.Diagnostics;
using System.IO;
using NUnit.Framework;

namespace MinMaxRiddle
{
    public class SolutionTest
    {
        [TestCase(new long[] { 6, 3, 5, 1, 12 }, new long[] { 12, 3, 3, 1, 1 })]
        [TestCase(new long[] { 2, 6, 1, 12 }, new long[] { 12, 2, 1, 1 })]
        [TestCase(new long[] { 1, 2, 3, 5, 1, 13, 3 }, new long[] { 13, 3, 2, 1, 1, 1, 1 })]
        [TestCase(new long[] { 3, 5, 4, 7, 6, 2 }, new long[] { 7, 6, 4, 4, 3, 2 })]
        [TestCase(new long[] { 6, 3, 5, 7, 12 }, new long[] { 12, 7, 5, 3, 3 })]
        [TestCase(new long[] { 7, 2, 3, 1, 8, 4, 5 }, new long[] { 8, 4, 4, 1, 1, 1, 1 })]
        [TestCase(new long[] { 7, 9, 6, 5, 1, 2, 8, 4, 3 }, new long[] { 9, 7, 6, 5, 1, 1, 1, 1, 1 })]
        [TestCase(new long[] { 4, 1, 7, 9, 6, 5, 8, 2, 3 }, new long[] { 9, 7, 6, 5, 5, 2, 2, 1, 1 })]
        [TestCase(new long[] { 11, 15, 2, 19, 16, 13, 6, 9, 18, 4, 17, 5, 20, 7, 8, 10, 1, 12, 14, 3 }, new long[] { 20, 16, 13, 7, 6, 6, 4, 4, 4, 4, 4, 4, 4, 2, 2, 2, 1, 1, 1, 1 })]
        [TestCase(new long[] { 19, 17, 15, 13, 11, 9, 7, 5, 3, 1, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 }, new long[] { 20, 18, 16, 14, 12, 10, 8, 6, 4, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 })]
        [TestCase(new long[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 20, 18, 16, 14, 12, 10, 8, 6, 4, 2 }, new long[] { 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 })]
        [TestCase(new long[] { 11, 2, 3, 14, 5, 2, 11, 12 }, new long[] { 14, 11, 3, 2, 2, 2, 2, 2 })]
        public void Test(long[] arr, long[] expected)
        {
            var actual = Solution.Riddle(arr);

            Assert.AreEqual(expected, actual);
        }

        [Ignore("To Optimize")]
        [TestCase(@"Resources\input02.txt", @"Resources\output02.txt")]
        public void Test2(string inputPath, string outputPath)
        {
            using var inputFile = new StreamReader(inputPath);

            inputFile.ReadLine();
            var arr = Array.ConvertAll(inputFile.ReadLine().Split(' '), Convert.ToInt64);

            var sw = Stopwatch.StartNew();
            sw.Start();

            var actual = Solution.RiddleV2(arr);

            sw.Stop();

            Console.WriteLine($"{sw.Elapsed.TotalMilliseconds}");

            using var outputFile = new StreamReader(outputPath);

            var expected = Array.ConvertAll(outputFile.ReadLine().Split(' '), Convert.ToInt64);

            Assert.AreEqual(expected, actual);
        }
    }
}
