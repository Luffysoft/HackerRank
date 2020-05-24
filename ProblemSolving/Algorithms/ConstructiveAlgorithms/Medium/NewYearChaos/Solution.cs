using System;
using System.Collections.Generic;
using System.Linq;

namespace NewYearChaos
{
    public static class Solution
    {
        private const string ErrorMessage = "Too chaotic";

        public static void MinimumBribes(int[] q)
        {
            var result = MinimumBribesWithResult(q)?.ToString() ?? ErrorMessage;
            Console.WriteLine(result);
        }

        public static int? MinimumBribesWithResult(int[] q)
        {
            if (!q.Any())
            {
                return 0;
            }

            var result = 0;
            var linkedList = new LinkedList<int>();

            linkedList.AddFirst(q.Last());

            for (var i = q.Length - 2; i >= 0; i--)
            {
                var node = linkedList.First;
                var j = 0;

                while (q[i] > node.Value && node.Next != null)
                {
                    node = node.Next;
                    j++;

                    if (j > 2)
                    {
                        return null;
                    }
                }

                if (q[i] < node.Value)
                {
                    linkedList.AddBefore(node, new LinkedListNode<int>(q[i]));
                }
                else
                {
                    j++;

                    if (j > 2)
                    {
                        return null;
                    }

                    linkedList.AddAfter(node, new LinkedListNode<int>(q[i]));
                }

                result += j;
            }

            return result;
        }
    }
}
