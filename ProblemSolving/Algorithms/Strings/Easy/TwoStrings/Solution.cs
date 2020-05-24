using System.Linq;

namespace TwoStrings
{
    public static class Solution
    {
        public static string TwoStrings(string s1, string s2)
        {
            return TwoStringsWithResult(s1, s2) ? "YES" : "NO";
        }

        public static bool TwoStringsWithResult(string s1, string s2)
        {
            var hashSet = s1.ToHashSet();

            return s2.Any(c => hashSet.Contains(c));
        }
    }
}
