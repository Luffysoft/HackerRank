namespace FlippingBits
{
    public static class Solution
    {
        public static long FlippingBits(long n)
        {
            return ~((uint)n);
        }
    }
}
