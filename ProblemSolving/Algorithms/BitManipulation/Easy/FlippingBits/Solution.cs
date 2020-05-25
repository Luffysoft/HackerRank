namespace FlippingBits
{
    public static class Solution
    {
        public static long FlippingBits(long n)
        {
            return n ^ ((long) 1 << 32) - 1;
        }
    }
}
