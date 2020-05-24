using System;
using System.Collections.Generic;
using System.Linq;

namespace LeftRotation
{
    public static class Solution
    {
        public static void RotLeft(int[] a, int d)
        {
            var result = RotLeftWithStringResult(a, d);
            Console.WriteLine(result);
        }

        public static string RotLeftWithStringResult(int[] a, int d)
        {
            var result = RotLeftWithResult(a, d);
            return string.Join(" ", result);
        }

        public static List<int> RotLeftWithResult(int[] a, int d)
        {
            if (d % a.Length == 0)
            {
                return a.ToList();
            }

            return a
                .Select((x, i) => a[(i + d) % a.Length])
                .ToList();
        }
    }
}
