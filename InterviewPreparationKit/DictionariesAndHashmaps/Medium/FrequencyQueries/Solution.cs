using System.Collections.Generic;

namespace FrequencyQueries
{
    public static class Solution
    {
        public static List<int> FreqQuery(List<List<int>> queries)
        {
            var result = new List<int>();
            var lookupByOccurence = new Dictionary<int, int>();
            var lookupByFrequency = new Dictionary<int, int>();

            foreach (var query in queries)
            {
                switch (query[0])
                {
                    case 1:
                        if (lookupByOccurence.ContainsKey(query[1]))
                        {
                            Decrement(lookupByFrequency, lookupByOccurence[query[1]]);
                        }

                        Increment(lookupByOccurence, query[1]);
                        Increment(lookupByFrequency, lookupByOccurence[query[1]]);

                        break;

                    case 2:
                        if (lookupByOccurence.ContainsKey(query[1]))
                        {
                            Decrement(lookupByFrequency, lookupByOccurence[query[1]]);
                        }

                        Decrement(lookupByOccurence, query[1]);

                        if (lookupByOccurence.ContainsKey(query[1]))
                        {
                            Increment(lookupByFrequency, lookupByOccurence[query[1]]);
                        }

                        break;

                    case 3:
                        result.Add(lookupByFrequency.ContainsKey(query[1]) ? 1 : 0);

                        break;
                }
            }

            return result;
        }

        private static void Increment(IDictionary<int, int> lookup, int index)
        {
            if (!lookup.ContainsKey(index))
            {
                lookup[index] = 0;
            }

            lookup[index]++;
        }

        private static void Decrement(IDictionary<int, int> lookup, int index)
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
