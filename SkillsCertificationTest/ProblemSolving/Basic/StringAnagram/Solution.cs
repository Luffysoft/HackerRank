using System.Collections.Generic;
using System.Linq;

namespace StringAnagram
{
    public static class Solution
    {
        public static List<int> StringAnagram(List<string> dictionary, List<string> queries)
        {
            var lookup = dictionary
                .Select(w => string.Concat(w.OrderBy(c => c)))
                .GroupBy(w => w)
                .ToDictionary(k => k.Key, v => v.Count());

            return queries
                .Select(w => string.Concat(w.OrderBy(c => c)))
                .Select(w => lookup.ContainsKey(w) ? lookup[w] : 0)
                .ToList();
        }
    }
}
