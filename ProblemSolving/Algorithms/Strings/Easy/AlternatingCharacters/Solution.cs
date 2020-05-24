using System.Linq;

namespace AlternatingCharacters
{
    public static class Solution
    {
        public static int AlternatingCharacters(string s)
        {
            var result = 0;

            var current = s[0];

            foreach (var letter in s.Skip(1))
            {
                if (letter == current)
                {
                    result++;
                }
                else
                {
                    current = letter;
                }
            }

            return result;
        }
    }
}
