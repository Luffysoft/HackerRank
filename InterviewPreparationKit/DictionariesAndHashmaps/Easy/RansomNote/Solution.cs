using System;
using System.Linq;

namespace RansomNote
{
    public static class Solution
    {
        public static void CheckMagazine(string[] magazine, string[] note)
        {
            var result = CheckMagazineWithResult(magazine, note) ? "Yes" : "No";
            Console.WriteLine(result);
        }

        public static bool CheckMagazineWithResult(string[] magazine, string[] note)
        {
            var wordMapping = magazine
                .GroupBy(m => m)
                .ToDictionary(g => g.Key, g => g.Count());

            foreach (var word in note)
            {
                if (!wordMapping.ContainsKey(word))
                {
                    return false;
                }

                wordMapping[word]--;

                if (wordMapping[word] == 0)
                {
                    wordMapping.Remove(word);
                }
            }

            return true;
        }
    }
}
