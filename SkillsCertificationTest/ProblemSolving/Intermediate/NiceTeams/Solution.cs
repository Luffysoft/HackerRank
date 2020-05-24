using System.Collections.Generic;

namespace NiceTeams
{
    public static class Solution
    {
        public static int MaxPairs(List<int> skillLevel, int minDiff)
        {
            var result = 0;

            skillLevel.Sort();

            var i = 0;
            var j = 1;
            while (i < skillLevel.Count - 1 && j < skillLevel.Count)
            {
                if (skillLevel[j] - skillLevel[i] >= minDiff)
                {
                    i++;
                    result++;
                }

                j++;
            }

            return result;
        }
    }
}
