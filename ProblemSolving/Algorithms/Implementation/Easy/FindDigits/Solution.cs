namespace FindDigits
{
    public static class Solution
    {
        public static int FindDigits(int number)
        {
            var remaining = number;
            var result = 0;

            while (remaining > 0)
            {
                var divisor = remaining % 10;

                if (divisor != 0 && number % divisor == 0)
                {
                    result++;
                }

                remaining /= 10;
            }

            return result;
        }
    }
}
