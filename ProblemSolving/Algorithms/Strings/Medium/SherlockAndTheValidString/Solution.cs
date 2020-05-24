using System.Collections.Generic;
using System.Linq;

namespace SherlockAndTheValidString
{
    public static class Solution
    {
        public static string IsValid(string s)
        {
            return IsValidWithResult(s) ? "YES" : "NO";
        }

        public static bool IsValidWithResult(string s)
        {
            var lookupByOccurence = new Dictionary<char, int>();
            var lookupByFrequency = new Dictionary<int, int>();

            foreach (var letter in s)
            {
                if (lookupByOccurence.ContainsKey(letter))
                {
                    Decrement(lookupByFrequency, lookupByOccurence[letter]);
                }

                Increment(lookupByOccurence, letter);
                Increment(lookupByFrequency, lookupByOccurence[letter]);
            }

            if (lookupByFrequency.Count > 2)
            {
                return false;
            }

            if (lookupByFrequency.Count == 2)
            {
                var frequencies = lookupByFrequency
                    .OrderBy(lbf => lbf.Key)
                    .Select(lbf => lbf);

                var firstFrequency = frequencies.First();
                var lastFrequency = frequencies.Last();

                if (lastFrequency.Value == 1 && lastFrequency.Key - firstFrequency.Key > 1)
                {
                    return false;
                }

                if (!(lastFrequency.Value == 1 || firstFrequency.Value == 1))
                {
                    return false;
                }
            }

            return true;
        }

        private static void Increment<T>(IDictionary<T, int> lookup, T index)
        {
            if (!lookup.ContainsKey(index))
            {
                lookup[index] = 0;
            }

            lookup[index]++;
        }

        private static void Decrement<T>(IDictionary<T, int> lookup, T index)
        {
            if (!lookup.ContainsKey(index))
            {
                return;
            }

            lookup[index]--;

            if (lookup[index] == 0)
            {
                lookup.Remove(index);
            }
        }
    }
}
