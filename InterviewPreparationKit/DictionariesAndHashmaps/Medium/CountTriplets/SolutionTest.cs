using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using NUnit.Framework;

namespace CountTriplets
{
    public class SolutionTest
    {
        [TestCase(new long[] { 1, 4, 16, 64 }, 4, 2)]
        [TestCase(new long[] { 1, 2, 2, 4 }, 2, 2)]
        [TestCase(new long[] { 1, 3, 9, 9, 27, 81 }, 3, 6)]
        [TestCase(new long[] { 1, 5, 5, 25, 125 }, 5, 4)]
        public void Test(long[] arr, long r, long expected)
        {
            var sw = Stopwatch.StartNew();
            sw.Start();

            var actual = Solution.CountTriplets(arr.ToList(), r);

            sw.Stop();

            Console.WriteLine($"{sw.Elapsed.TotalMilliseconds}");

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new long[] { 1, 4, 16, 64 }, 4, 2)]
        [TestCase(new long[] { 1, 2, 2, 4 }, 2, 2)]
        [TestCase(new long[] { 1, 3, 9, 9, 27, 81 }, 3, 6)]
        [TestCase(new long[] { 1, 5, 5, 25, 125 }, 5, 4)]
        public void Test2(long[] arr, long r, long expected)
        {
            var sw = Stopwatch.StartNew();
            sw.Start();

            var actual = Solution.CountTripletsV2(arr.ToList(), r);

            sw.Stop();

            Console.WriteLine($"{sw.Elapsed.TotalMilliseconds}");

            Assert.AreEqual(expected, actual);
        }

        [TestCase(@"Resources\input03.txt", 166661666700000)]
        [TestCase(@"Resources\input04.txt", 0)]
        [TestCase(@"Resources\input06.txt", 2325652489)]
        [TestCase(@"Resources\input11.txt", 1667018988625)]
        public void TestFile(string path, long expected)
        {
            using var file = new StreamReader(path);

            var nr = file.ReadLine().TrimEnd().Split(' ');
            var r = Convert.ToInt64(nr[1]);
            var list = file.ReadLine().TrimEnd().Split(' ').ToList();
            var arr = list.Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

            var sw = Stopwatch.StartNew();
            sw.Start();

            var actual = Solution.CountTripletsV2(arr.ToList(), r);

            sw.Stop();

            Console.WriteLine($"{sw.Elapsed.TotalMilliseconds}");

            Assert.AreEqual(expected, actual);
        }
    }
}
