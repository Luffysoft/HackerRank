namespace InsertANodeAtASpecificPositionInALinkedList
{
    public static class Solution
    {
        public static SinglyLinkedListNode InsertNodeAtPosition(SinglyLinkedListNode head, int data, int position)
        {
            var current = head;

            var i = 1;
            while (current != null)
            {
                if (i == position)
                {
                    var node = new SinglyLinkedListNode(data);

                    if (current.Next != null)
                    {
                        node.Next = current.Next;
                    }

                    current.Next = node;
                }

                current = current.Next;
                i++;
            }

            return head;
        }
    }
}
