using System.Collections.Generic;

namespace DavisStaircase
{
    public static class Solution
    {
        private const long Divisor = 10_000_000_007;

        public static int StepPerms(int n)
        {
            var lookup = new Dictionary<int, long>
            {
                [1] = 1,
                [2] = 2,
                [3] = 4,
            };

            for (var i = 4; i <= n; i++)
            {
                lookup[i] = lookup[i - 1] % Divisor +
                            lookup[i - 2] % Divisor +
                            lookup[i - 3] % Divisor;
            }

            return (int) lookup[n];
        }
    }
}
