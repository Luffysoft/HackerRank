using System;

namespace MinMaxRiddle
{
    public static class Solution
    {
        public static long[] Riddle(long[] arr)
        {
            var lookup = new long[arr.Length];
            var result = new long[arr.Length];

            for (var j = 0; j < arr.Length; j++)
            {
                lookup[j] = arr[j];
                result[0] = Math.Max(result[0], lookup[j]);
            }

            for (var i = 1; i < arr.Length; i++)
            {
                for (var j = i; j < arr.Length; j++)
                {
                    lookup[j - i] = Math.Min(lookup[j - i], arr[j]);
                    result[i] = Math.Max(result[i], lookup[j - i]);
                }
            }

            return result;
        }

        public static long[] RiddleV2(long[] arr)
        {
            var lookup = new long[arr.Length];
            var result = new long[arr.Length];

            var min = long.MaxValue;

            for (var j = 0; j < arr.Length; j++)
            {
                lookup[j] = arr[j];
                result[0] = Math.Max(result[0], lookup[j]);
                min = Math.Min(min, lookup[j]);
            }

            for (var i = 1; i < arr.Length; i++)
            {
                for (var j = i; j < arr.Length; j++)
                {
                    lookup[j - i] = Math.Min(lookup[j - i], arr[j]);
                    result[i] = Math.Max(result[i], lookup[j - i]);
                }

                if (result[i] == min)
                {
                    for (var j = i + 1; j < result.Length; j++)
                    {
                        result[j] = min;
                    }

                    break;
                }
            }

            return result;
        }
    }
}
