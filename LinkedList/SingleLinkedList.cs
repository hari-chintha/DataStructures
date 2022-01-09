namespace LinkedList
{
    public class SingleLinkedList
    {
        internal SingleNode head;

        public void append(int data)
        {
            if (head == null)
            {
                head = new SingleNode(data);
                return;
            }
            SingleNode current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new SingleNode(data);
        }

        public void prepend(int data)
        {
            SingleNode newHead = new SingleNode(data);
            newHead.next = head;
            head = newHead;
        }

        public void deleteWithValue(int data)
        {
            if(head == null)
            {
                return;
            }
            if(head.data == data)
            {
                head = head.next;
                return;
            }
            SingleNode current = head;
            while(current.next != null)
            {
                if(current.next.data == data)
                {
                    current.next = current.next.next;
                    return;
                }
                current = current.next;
            }
        }
    }
}
