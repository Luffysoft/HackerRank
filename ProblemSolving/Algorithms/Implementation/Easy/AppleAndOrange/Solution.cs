using System;
using System.Linq;

namespace AppleAndOrange
{
    public static class Solution
    {
        public static void CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            var result = CountApplesAndOrangesWithResult(s, t, a, b, apples, oranges);
            Array.ForEach(result, Console.WriteLine);
        }

        public static int[] CountApplesAndOrangesWithResult(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            var nbApples = apples.Count(apple => a + apple >= s && a + apple <= t);
            var nbOranges = oranges.Count(orange => b + orange >= s && b + orange <= t);

            return new [] { nbApples, nbOranges };
        }
    }
}
