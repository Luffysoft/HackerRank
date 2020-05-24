using System;
using System.Diagnostics;
using System.IO;
using NUnit.Framework;

namespace LargestRectangle
{
    public class SolutionTest
    {
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 9)]
        [TestCase(new[] { 4, 2, 1, 3, 2, 5, 6, 1, 4 }, 10)]
        [TestCase(new[] { 4, 2, 1, 3, 2, 7, 6, 1, 4 }, 12)]
        public void Test(int[] h, long expected)
        {
            var actual = Solution.LargestRectangle(h);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { 1, 2, 3, 4, 5 }, 9)]
        [TestCase(new[] { 4, 2, 1, 3, 2, 5, 6, 1, 4 }, 10)]
        [TestCase(new[] { 4, 2, 1, 3, 2, 7, 6, 1, 4 }, 12)]
        [TestCase(new[] { 4, 2, 1, 3, 2, 7, 6, 1, 4, 1, 1, 1, 1, 1 }, 14)]
        public void Test2(int[] h, long expected)
        {
            var actual = Solution.LargestRectangleV3(h);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(@"Resources\input13.txt", 12133211)]
        public void Test3(string path, long expected)
        {
            using var file = new StreamReader(path);

            file.ReadLine();
            var h = Array.ConvertAll(file.ReadLine().Split(' '), Convert.ToInt32);

            var sw = Stopwatch.StartNew();
            sw.Start();

            var actual = Solution.LargestRectangleV3(h);

            sw.Stop();

            Console.WriteLine($"{sw.Elapsed.TotalMilliseconds}");

            Assert.AreEqual(expected, actual);
        }
    }
}
