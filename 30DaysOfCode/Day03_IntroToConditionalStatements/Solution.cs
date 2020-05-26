using System;

namespace Day03_IntroToConditionalStatements
{
    public static class Solution
    {
        public static void IsWeird(int number)
        {
            var result = IsWeirdWithResult(number) ? "Weird" : "Not Weird";
            Console.WriteLine(result);
        }

        public static bool IsWeirdWithResult(double number)
        {
            return IsOdd(number) || IsBetween(number, 6, 20);
        }

        private static bool IsOdd(double number)
        {
            return number % 2 == 1;
        }

        private static bool IsBetween(double number, double left, double right)
        {
            return number >= left && number <= right;
        }
    }
}
