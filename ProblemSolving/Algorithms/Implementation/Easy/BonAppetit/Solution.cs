using System;
using System.Collections.Generic;
using System.Linq;

namespace BonAppetit
{
    public static class Solution
    {
        public static void BonAppetit(List<int> bill, int k, int b)
        {
            var result = BonAppetitWithResult(bill, k, b);
            var resultString = result != null ? result.ToString() : "Bon Appetit";
            Console.WriteLine(resultString);
        }

        public static int? BonAppetitWithResult(List<int> bill, int k, int b)
        {
            var sum = bill
                .Where((d, i) => k != i)
                .Sum();
            var diff = b - sum / 2;

            return diff != 0 ? diff : (int?) null;
        }
    }
}
