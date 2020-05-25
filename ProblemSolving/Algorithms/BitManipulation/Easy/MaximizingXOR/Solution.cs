using System;

namespace MaximizingXOR
{
    public static class Solution
    {
        public static int MaximizingXor(int l, int r)
        {
            var max = 0;

            for (var i = l; i <= r; i++)
            {
                for (var j = l; j <= r; j++)
                {
                    max = Math.Max(max, i ^ j);
                }
            }

            return max;
        }
        public static int MaximizingXorV2(int l, int r)
        {
            var xor = l ^ r;
            var nbDigits = TotalBinaryDigits(xor);
            var result = (1 << nbDigits) - 1;

            return result;
        }

        private static int TotalBinaryDigits(int n)
        {
            var nbDigits = 1;

            while ((n >>= 1) > 0)
            {
                nbDigits++;
            }

            return nbDigits;
        }
    }
}
