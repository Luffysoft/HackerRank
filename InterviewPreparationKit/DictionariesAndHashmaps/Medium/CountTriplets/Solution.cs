using System.Collections.Generic;

namespace CountTriplets
{
    public static class Solution
    {
        public static long CountTriplets(List<long> arr, long r)
        {
            var result = 0L;

            for (var i = 0; i < arr.Count - 2; i++)
            {
                for (var j = i + 1; j < arr.Count - 1; j++)
                {
                    if (arr[j] != arr[i] * r)
                    {
                        continue;
                    }

                    for (var k = j + 1; k < arr.Count; k++)
                    {
                        if (arr[k] != arr[j] * r)
                        {
                            continue;
                        }

                        result++;
                    }
                }
            }

            return result;
        }

        public static long CountTripletsV2(List<long> arr, long r)
        {
            var mp2 = new Dictionary<long, long>();
            var mp3 = new Dictionary<long, long>();
            var result = 0L;

            foreach (var val in arr)
            {
                if (mp3.ContainsKey(val))
                {
                    result += mp3[val];
                }

                if (mp2.ContainsKey(val))
                {
                    if (mp3.ContainsKey(val * r))
                    {
                        mp3[val * r] += mp2[val];
                    }
                    else
                    {
                        mp3[val * r] = mp2[val];
                    }
                }

                if (mp2.ContainsKey(val * r))
                {
                    mp2[val * r]++;
                }
                else
                {
                    mp2[val * r] = 1;
                }
            }

            return result;
        }
    }
}
