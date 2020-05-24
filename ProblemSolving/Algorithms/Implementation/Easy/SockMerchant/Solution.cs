using System.Linq;

namespace SockMerchant
{
    public static class Solution
    {
        public static int SockMerchant(int[] socks)
        {
            return socks
                .GroupBy(v => v)
                .Sum(d => d.Count() / 2);
        }
    }
}
