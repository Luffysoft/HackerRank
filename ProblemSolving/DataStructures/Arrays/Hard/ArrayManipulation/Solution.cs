using System;

namespace ArrayManipulation
{
    public static class Solution
    {
        public static long ArrayManipulation(int n, int[][] queries)
        {
            var arr = new long[n];

            foreach (var record in queries)
            {
                arr[record[0] - 1] += record[2];

                if (record[1] - 1 < n - 1)
                {
                    arr[record[1]] -= record[2];
                }
            }

            var max = 0L;
            var sum = 0L;
            foreach (var number in arr)
            {
                sum += number;
                max = Math.Max(max, sum);
            }

            return max;
        }
    }
}
