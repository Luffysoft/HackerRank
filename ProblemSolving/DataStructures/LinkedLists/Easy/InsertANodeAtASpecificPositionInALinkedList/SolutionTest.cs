using NUnit.Framework;
using System.Collections.Generic;

namespace InsertANodeAtASpecificPositionInALinkedList
{
    public class SolutionTest
    {
        private static IEnumerable<(SinglyLinkedListNode head, int data, int position, SinglyLinkedListNode expected)> Scenarios()
        {
            var head = new SinglyLinkedList();
            var headInputs = new List<int> { 13, 16, 7 };
            headInputs.ForEach(head.InsertNode);

            var expected = new SinglyLinkedList();
            var expectedInputs = new List<int> { 13, 16, 1, 7 };
            expectedInputs.ForEach(expected.InsertNode);

            yield return
            (
                head.Head,
                1,
                2,
                expected.Head
            );


            head = new SinglyLinkedList();
            headInputs = new List<int> { 13, 16, 7 };
            headInputs.ForEach(head.InsertNode);

            expected = new SinglyLinkedList();
            expectedInputs = new List<int> { 13, 16, 7, 1 };
            expectedInputs.ForEach(expected.InsertNode);

            yield return
            (
                head.Head,
                1,
                3,
                expected.Head
            );
        }

        [TestCaseSource(nameof(Scenarios))]
        public void Test((SinglyLinkedListNode head, int data, int position, SinglyLinkedListNode expected) scenarios)
        {
            var (head, data, position, expected) = scenarios;

            var actual = Solution.InsertNodeAtPosition(head, data, position);

            var actualList = SinglyLinkedListToList(actual);
            var expectedList = SinglyLinkedListToList(expected);

            CollectionAssert.AreEquivalent(expectedList, actualList);
        }

        private IEnumerable<int> SinglyLinkedListToList(SinglyLinkedListNode llist)
        {
            var list = new List<int>();

            var current = llist;
            while (current != null)
            {
                list.Add(current.Data);
                current = current.Next;
            }

            return list;
        }
    }
}
