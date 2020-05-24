using System;
using System.Collections.Generic;

namespace BalancedSystemFilesPartition
{
    public static class Solution
    {
        private const int ROOT_INDEX = -1;

        public static int MostBalancedPartition(List<int> parents, List<int> sizes)
        {
            var root = BuildTree(parents, sizes, out var fullSize);
            return FindBestMatch(root, fullSize);
        }

        private static Node BuildTree(IList<int> parents, IList<int> sizes, out int fullSize)
        {
            var lookup = new Dictionary<int, Node>();
            fullSize = 0;

            for (var i = 0; i < parents.Count; i++)
            {
                AddNode(lookup, i, parents[i], sizes[i]);
                fullSize += sizes[i];
            }

            var root = lookup[0];

            lookup.Clear();

            return root;
        }

        private static int FindBestMatch(Node root, int fullSize)
        {
            var result = int.MaxValue;

            FindBestMatchRec(root, fullSize, ref result);

            return result;
        }

        private static int FindBestMatchRec(Node root, int fullSize, ref int result)
        {
            var totalSize = root.Data;

            foreach (var child in root.Children)
            {
                totalSize += FindBestMatchRec(child, fullSize, ref result);

                if (result == 0)
                {
                    return 0;
                }
            }

            result = Math.Min(result, Math.Abs(Math.Abs(fullSize - totalSize) - totalSize));

            return totalSize;
        }

        private static void AddNode(IDictionary<int, Node> lookup, int nodeIndex, int parentIndex, int size)
        {
            var node = new Node(size);
            lookup[nodeIndex] = node;

            if (parentIndex == ROOT_INDEX || !lookup.ContainsKey(parentIndex))
            {
                return;
            }

            var parentNode = lookup[parentIndex];
            parentNode.AddChildren(node);
        }

        private class Node
        {
            public Node(int data)
            {
                Children = new List<Node>();
                Data = data;
            }

            public List<Node> Children { get; }

            public int Data { get; }

            public void AddChildren(Node node)
            {
                Children.Add(node);
            }
        }
    }
}
