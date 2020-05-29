using System.Collections.Generic;

namespace FibonacciNumbers
{
    public static class Solution
    {
        private static readonly IDictionary<int, int> Lookup = new Dictionary<int, int>
        {
            [0] = 0,
            [1] = 1
        };

        public static int Fibonacci(int n)
        {
            if (Lookup.ContainsKey(n))
            {
                return Lookup[n];
            }

            var result = Fibonacci(n - 1) + Fibonacci(n - 2);

            Lookup[n] = result;

            return result;
        }
    }
}
