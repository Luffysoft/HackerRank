using System;
using System.Linq;

namespace _2DArray
{
    public static class Solution
    {
        public static int HourglassSum(int[][] arr)
        {
            var result = int.MinValue;

            for (var i = 0; i <= arr.Length - 3; i++)
            {
                for (var j = 0; j <= arr[i].Length - 3; j++)
                {
                    var sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    result = Math.Max(result, sum);
                }
            }

            return result;
        }

        private static readonly (int i, int j)[] Patterns =
        {
            (0, 0),
            (0, 1),
            (0, 2),
            (1, 1),
            (2, 0),
            (2, 1),
            (2, 2)
        };

        public static int HourglassSumV2(int[][] arr)
        {
            var result = int.MinValue;

            var shift = Shift();

            for (var i = 0; i <= arr.Length - shift.i; i++)
            {
                for (var j = 0; j <= arr[i].Length - shift.j; j++)
                {
                    var sum = Patterns
                        .Select(p => arr[i + p.i][j + p.j])
                        .Sum();
                    result = Math.Max(result, sum);
                }
            }

            return result;
        }

        private static (int i, int j) Shift()
        {
            var (i, j) = MinMax();
            return (i.max - i.min + 1, j.max - j.min + 1);
        }

        private static ((int min, int max) i, (int min, int max) j) MinMax()
        {
            ((int min, int max) i, (int min, int max) j) initialMinMax = ((0, 0), (0, 0));

            return Patterns.Aggregate(initialMinMax, (r, p) =>
            {
                r.i.min = Math.Min(r.i.min, p.i);
                r.i.max = Math.Max(r.i.max, p.i);
                r.j.min = Math.Min(r.j.min, p.j);
                r.j.max = Math.Max(r.j.max, p.j);

                return r;
            });
        }
    }
}
