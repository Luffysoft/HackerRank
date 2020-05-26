using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PlusMinus
{
    public static class Solution
    {
        public static void PlusMinus(int[] arr)
        {
            var result = PlusMinusWithResult(arr);
            Array.ForEach(result, Console.WriteLine);
        }

        public static double[] PlusMinusWithResult(int[] arr)
        {
            var nbPositives = 0;
            var nbNegatives = 0;
            var nbZeroes = 0;

            foreach (var element in arr)
            {
                if (element > 0)
                {
                    nbPositives++;
                }
                else if (element < 0)
                {
                    nbNegatives++;
                }
                else
                {
                    nbZeroes++;
                }
            }

            return new []
            {
                (double) nbPositives / arr.Length,
                (double) nbNegatives / arr.Length,
                (double) nbZeroes / arr.Length
            };
        }

        public static double[] PlusMinusWithResultV2(int[] arr)
        {
            return Enumerable
                .Range(0, 3)
                .GroupJoin(
                    arr.Select(e => new { Index = e > 0 ? 0 : (e < 0 ? 1 : 2), Element = e }),
                    i => i,
                    e => e.Index,
                    (i, e) => (Index: i, Count: e.Count()))
                .Select(gj => (double) gj.Count / arr.Length)
                .ToArray();
        }
    }
}
