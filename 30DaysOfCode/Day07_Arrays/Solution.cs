using System;
using System.Linq;

namespace Day07_Arrays
{
    public static class Solution
    {
        public static void Solve(int[] arr)
        {
            var result = SolveWithResult(arr)
                .Select(n => n.ToString());
            var message = string.Join(" ", result);
            Console.WriteLine(message);
        }

        public static int[] SolveWithResult(int[] arr)
        {
            return arr
                .Reverse()
                .ToArray();
        }
    }
}
