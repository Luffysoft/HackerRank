using System.Collections.Generic;

namespace ATaleOfTwoStacks
{
    public static class Solution
    {
        public static List<int> ProcessQueries(List<List<int>> queries)
        {
            var queue = new Queue<int>();
            var result = new List<int>();

            foreach (var query in queries)
            {
                switch (query[0])
                {
                    case 1:
                        queue.Enqueue(query[1]);
                        break;

                    case 2:
                        queue.Dequeue();
                        break;

                    case 3:
                        result.Add(queue.Peek());
                        break;
                }
            }

            return result;
        }
    }
}
