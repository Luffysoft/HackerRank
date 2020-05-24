using System;
using System.Collections.Generic;

namespace BubbleSort
{
    public static class Solution
    {
        public static void CountSwaps(int[] a)
        {
            var nbSwaps = 0;

            for (var i = 0; i < a.Length; i++)
            {
                for (var j = 0; j < a.Length - 1; j++)
                {
                    if (a[j] <= a[j + 1])
                    {
                        continue;
                    }

                    Swap(a, j, j + 1);
                    nbSwaps++;
                }
            }

            Console.WriteLine($"Array is sorted in {nbSwaps} swaps.");
            Console.WriteLine($"First Element: {a[0]}");
            Console.WriteLine($"Last Element: {a[^1]}");
        }

        private static void Swap(IList<int> a, int i, int j)
        {
            var tmp = a[i];
            a[i] = a[j];
            a[j] = tmp;
        }
    }
}
