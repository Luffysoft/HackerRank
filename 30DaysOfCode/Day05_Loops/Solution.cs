using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace Day05_Loops
{
    public static class Solution
    {
        public static void MultiplyTable(int n)
        {
            MultiplyTableWithResult(n)
                .ForEach(r => Console.WriteLine($"{r.i} + {r.n} = {r.m}"));
        }

        public static IEnumerable<(int i, int n, int m)> MultiplyTableWithResult(int n)
        {
            return Enumerable
                .Range(1, 10)
                .Select(i => (i, n, n * i));
        }
    }
}
