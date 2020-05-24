using System;

namespace DiagonalDifference
{
    public static class Solution
    {
        public static int DiagonalDifference(int[][] a)
        {
            var diagonal1 = 0;
            var diagonal2 = 0;
            var len = a.GetLength(0);

            for (var i = 0; i < len; ++i)
            {
                diagonal1 += a[i][i];
                diagonal2 += a[len - i - 1][i];
            }

            return Math.Abs(diagonal2 - diagonal1);
        }
    }
}
