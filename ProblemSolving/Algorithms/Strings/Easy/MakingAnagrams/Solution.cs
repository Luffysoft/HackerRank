using System;
using System.Linq;

namespace MakingAnagrams
{
    public static class Solution
    {
        public static int MakingAnagrams(string a, string b)
        {
            var letterMapping = a
                .GroupBy(k => k, v => v)
                .ToDictionary(g => g.Key, g => g.Count());

            foreach (var letter in b)
            {
                if (!letterMapping.ContainsKey(letter))
                {
                    letterMapping[letter] = 0;
                }

                letterMapping[letter]--;
            }

            return letterMapping
                .Values
                .Sum(Math.Abs);
        }

        public static int MakingAnagramsV2(string a, string b)
        {
            var letterMappingA = a
                .GroupBy(l => l)
                .Select(g => new { g.Key, Count = g.Count() });

            var letterMappingB = b
                .GroupBy(l => l)
                .Select(g => new { g.Key, Count = -g.Count() });

            return letterMappingA
                .Concat(letterMappingB)
                .GroupBy(
                    g => g.Key,
                    g => g.Count,
                    (l, cs) => Math.Abs(cs.Sum(c => c)))
                .Sum();
        }
    }
}