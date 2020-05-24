using System;

namespace MarkAndToys
{
    public static class Solution
    {
        public static int MaximumToys(int[] prices, int k)
        {
            var result = 0;

            Array.Sort(prices);

            foreach (var price in prices)
            {
                k -= price;

                if (k < 0)
                {
                    break;
                }

                result++;
            }

            return result;
        }
    }
}
