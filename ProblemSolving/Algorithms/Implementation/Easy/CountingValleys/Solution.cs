using System.Collections.Generic;

namespace CountingValleys
{
    public static class Solution
    {
        private const char StepUp = 'U';
        private const char StepDown = 'D';

        private static readonly Dictionary<char, int> StepMapping = new Dictionary<char, int>
        {
            [StepUp] = 1,
            [StepDown] = -1
        };

        public static int CountingValleys(string steps)
        {
            var result = 0;
            var level = 0;

            foreach (var step in steps)
            {
                if (level == 0 && step == StepDown)
                {
                    result++;
                }

                level += StepMapping[step];
            }

            return result;
        }
    }
}
