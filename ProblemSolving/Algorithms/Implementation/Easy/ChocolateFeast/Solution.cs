namespace ChocolateFeast
{
    public static class Solution
    {
        public static int ChocolateFeast(int n, int c, int m)
        {
            var nbWrappers = n / c;
            var result = nbWrappers;

            while (nbWrappers >= m)
            {
                var nbFreeBars = nbWrappers / m;
                nbWrappers = nbFreeBars + nbWrappers % m;
                result += nbFreeBars;
            }

            return result;
        }
    }
}
