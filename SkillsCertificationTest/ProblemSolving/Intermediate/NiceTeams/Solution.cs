using System.Collections.Generic;

namespace NiceTeams
{
    public static class Solution
    {
        public static int MaxPairs(List<int> skillLevels, int minDiff)
        {
            var result = 0;

            skillLevels.Sort();

            var i = 0;
            var j = 1;
            while (i < skillLevels.Count - 1 && j < skillLevels.Count)
            {
                if (skillLevels[j] - skillLevels[i] >= minDiff)
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
