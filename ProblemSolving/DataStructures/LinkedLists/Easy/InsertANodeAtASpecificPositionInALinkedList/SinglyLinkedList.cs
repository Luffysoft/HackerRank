namespace InsertANodeAtASpecificPositionInALinkedList
{
    public class SinglyLinkedList
    {
        public SinglyLinkedListNode Head { get; private set; }

        public void InsertNode(int data)
        {
            var node = new SinglyLinkedListNode(data);

            if (Head == null)
            {
                Head = node;
                return;
            }

            var current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = node;
        }
    }
}
