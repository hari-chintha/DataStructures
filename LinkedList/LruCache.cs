using System.Collections.Generic;

namespace LinkedList
{
    public class LruCache
    {
        Node head = new Node(int.MinValue, int.MinValue);
        Node tail = new Node(int.MaxValue, int.MaxValue);
        Dictionary<int, Node> dict = new Dictionary<int, Node>();
        int _count = 0;
        int _capacity = 0;

        public LruCache(int capacity)
        {
            this._capacity = capacity;
            head.next = tail;
            tail.prev = head;
        }

        public int get(int key)
        {
            if (!dict.ContainsKey(key))
            {
                return -1;
            }

            var node = dict[key];
            if (head.next != node)
            {
                var prev = node.prev;
                var next = node.next;
                var hnext = head.next;

                prev.next = next;
                next.prev = prev;
                head.next = node;
                node.prev = head;
                node.next = hnext;
                hnext.prev = node;
            }

            return node.value;
        }

        public void put(int key, int value)
        {
            if (dict.ContainsKey(key))
            {
                var node = dict[key];
                node.value = value;
                get(key);
            }
            else
            {
                if(_count == _capacity)
                {
                    var lastButOne = tail.prev;
                    var lastButSecond = lastButOne.prev;

                    lastButSecond.next = tail;
                    tail.prev = lastButSecond;

                    dict.Remove(lastButOne.key);
                    _count--;
                }

                var newNode = new Node(key, value);
                var hNext = head.next;

                head.next = newNode;
                newNode.prev = head;
                newNode.next = hNext;
                hNext.prev = newNode;
                dict.Add(key, newNode);
                _count++;
            }
        }
    }

    public class Node
    {
        public int key;
        public int value;
        public Node prev;
        public Node next;
        public Node(int key, int value, Node p = null, Node n = null)
        {
            this.key = key;
            this.value = value;
            prev = p;
            next = n;
        }
    }
}
