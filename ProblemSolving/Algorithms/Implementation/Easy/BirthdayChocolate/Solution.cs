using System.Collections.Generic;
using System.Linq;

namespace BirthdayChocolate
{
    public static class Solution
    {
        public static int Birthday(List<int> s, int d, int m)
        {
            var result = 0;

            for (var i = 0; i < s.Count - m + 1; i++)
            {
                var sum = 0;
                for (var j = i; j < i + m; j++)
                {
                    sum += s[j];
                }

                if (sum == d)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
