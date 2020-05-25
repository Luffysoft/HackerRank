using System;

namespace Day02_Operators
{
    public static class Solution
    {
        public static void Solve(double mealCost, int tipPercent, int taxPercent)
        {
            var result = SolveWithResult(mealCost, tipPercent, taxPercent);
            Console.WriteLine(result);
        }

        public static int SolveWithResult(double mealCost, int tipPercent, int taxPercent)
        {
            var price = mealCost * (1 + (double) (tipPercent + taxPercent) / 100);
            return Convert.ToInt32(price);
        }
    }
}
