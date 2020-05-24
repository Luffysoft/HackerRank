using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using NUnit.Framework;

namespace ArrayManipulation
{
    public class SolutionTest
    {
        private static IEnumerable<(int, int[][], long)> Scenarios()
        {
            yield return
            (
                5,
                new[]
                {
                    new [] { 1, 2, 100 },
                    new [] { 2, 5, 100 },
                    new [] { 3, 4, 100 }
                },
                200
            );

            yield return
            (
                10,
                new[]
                {
                    new [] { 2, 6, 8 },
                    new [] { 3, 5, 7 },
                    new [] { 1, 8, 1 },
                    new [] { 5, 9, 15 }
                },
                31
            );
        }

        [TestCase(@"Resources\input07.txt", 2497169732)]
        public void Test2(string path, long expected)
        {
            using var file = new StreamReader(path);

            var nm = file.ReadLine().Split(' ');
            var n = Convert.ToInt32(nm[0]);
            var m = Convert.ToInt32(nm[1]);
            var queries = new int[m][];

            string line;
            long i = 0;

            while ((line = file.ReadLine()) != null)
            {
                queries[i] = Array.ConvertAll(line.Split(' '), Convert.ToInt32);
                i++;
            }

            var sw = Stopwatch.StartNew();
            sw.Start();

            var actual = Solution.ArrayManipulation(n, queries);

            sw.Stop();

            Console.WriteLine(sw.Elapsed.Milliseconds);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(Scenarios))]
        public void Test((int, int[][], long) scenarios)
        {
            var (n, queries, expected) = scenarios;

            var actual = Solution.ArrayManipulation(n, queries);

            Assert.AreEqual(expected, actual);
        }
    }
}
