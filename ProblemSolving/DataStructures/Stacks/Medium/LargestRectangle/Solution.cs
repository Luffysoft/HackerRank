using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestRectangle
{
    public static class Solution
    {
        const int MAX_HEIGHT = 1_000_000;

        public static long LargestRectangle(int[] h)
        {
            var lookup = new int[MAX_HEIGHT];

            for (var j = 1; j <= h[^1]; j++)
            {
                lookup[j - 1] = 1;
            }

            long maxArea = h[^1];

            for (var i = h.Length - 2; i >= 0; i--)
            {
                for (var j = 1; j <= h[i]; j++)
                {
                    lookup[j - 1] = j <= h[i + 1] ? lookup[j - 1] + 1 : 1;
                    maxArea = Math.Max(maxArea, lookup[j - 1] * j);
                }
            }

            return maxArea;
        }

        private class Data
        {
            public Data(int maxSibling, int maxHeight)
            {
                MaxSibling = maxSibling;
                MaxHeight = maxHeight;
            }

            public int MaxSibling { get; set; }
            public int MaxHeight { get; set; }
        }

        public static long LargestRectangleV2(int[] h)
        {
            var previousLookup = new Queue<Data>();

            previousLookup.Enqueue(new Data(1, h[^1]));
            long maxArea = h[^1];

            for (var i = h.Length - 2; i >= 0; i--)
            {
                var lookup = new Queue<Data>();

                var previousData = previousLookup.Dequeue();
                var data = new Data(previousData.MaxSibling + 1, 1);
                lookup.Enqueue(data);

                for (var j = 1; j <= h[i]; j++)
                {
                    if (j > previousData.MaxHeight && previousData.MaxSibling > 0)
                    {
                        if (previousLookup.Any())
                        {
                            previousData = previousLookup.Dequeue();
                        }
                        else
                        {
                            previousData.MaxSibling = 0;
                        }
                    }

                    if (data.MaxSibling == previousData.MaxSibling + 1)
                    {
                        data.MaxHeight = j;
                    }
                    else
                    {
                        data = new Data(previousData.MaxSibling + 1, j);
                        lookup.Enqueue(data);
                    }

                    maxArea = Math.Max(maxArea, data.MaxSibling * j);
                }

                previousLookup = lookup;
            }

            return maxArea;
        }

        public static long LargestRectangleV3(int[] h)
        {
            var maxArea = 0L;

            for (var i = 0; i < h.Length; i++)
            {
                var nbBuilding = 1;

                var l = i - 1;
                while (l >= 0)
                {
                    if (h[l] < h[i])
                    {
                        break;
                    }

                    nbBuilding++;
                    l--;
                }

                var r = i + 1;
                while (r < h.Length)
                {
                    if (h[r] < h[i])
                    {
                        break;
                    }

                    nbBuilding++;
                    r++;
                }

                maxArea = Math.Max(maxArea, nbBuilding * h[i]);
            }

            return maxArea;
        }
    }
}
