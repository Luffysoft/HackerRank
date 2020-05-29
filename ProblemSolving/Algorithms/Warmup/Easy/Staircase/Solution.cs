using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace Staircase
{
    public static class Solution
    {
        public static void Staircase(int n)
        {
            var result = StaircaseWithResult(n);
            result
                .ForEach(i =>
                {
                    var sb = new StringBuilder(n);

                    i.ForEach(j => sb.Append(j));
                    Console.WriteLine(sb.ToString());
                });
        }

        public static IEnumerable<IEnumerable<char>> StaircaseWithResult(int n)
        {
            return Enumerable
                .Range(1, n)
                .Select(r => Enumerable
                    .Range(1, n)
                    .Select(j => j < n - r + 1 ? ' ' : '#'));
        }
    }
}
