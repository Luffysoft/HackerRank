namespace SumVsXOR
{
    public static class Solution
    {
        public static long SumXor(long n)
        {
            var result = 1L;

            for (long i = 1; i <= n; i++)
            {
                if (i + n == (i ^ n))
                {
                    result++;
                }
            }

            return result;
        }
        public static long SumXorV2(long n)
        {
            var result = 1L;

            while (n > 0)
            {
                if (n % 2 == 0)
                {
                    result <<= 1;
                }

                n >>= 1;
            }

            return result;
        }
    }
}
