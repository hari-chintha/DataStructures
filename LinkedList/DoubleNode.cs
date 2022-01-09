namespace LinkedList
{
    public class DoubleNode
    {
        public DoubleNode next;
        public DoubleNode previous;
        public int data;

        public DoubleNode(int data)
        {
            this.data = data;
            next = null;
            previous = null;
        }
    }
}
