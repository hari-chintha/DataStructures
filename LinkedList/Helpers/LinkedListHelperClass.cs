using System;

namespace LinkedList.Helpers
{
    public static class LinkedListHelperClass
    {
        internal static void append(SingleLinkedList singleLinkedList, int data)
        {
            if (singleLinkedList.head == null)
            {
                singleLinkedList.head = new SingleNode(data);
                return;
            }
            var currentNode = singleLinkedList.head;
            while(currentNode.next != null)
            {
                currentNode = currentNode.next;
            }
            currentNode.next = new SingleNode(data);

        }

        internal static void append(DoubleLinkedList doubleLinkedList, int data)
        {
            var newNode = new DoubleNode(data);
            if(doubleLinkedList.head == null)
            {
                newNode.previous = null;
                doubleLinkedList.head = newNode;
                return;
            }
            var currentHead = doubleLinkedList.head;
            while(currentHead.next != null)
            {
                currentHead = currentHead.next;
            }
            currentHead.next = newNode;
            newNode.previous = currentHead;
        }

        internal static void prepend(SingleLinkedList singleLinkedList, int data)
        {
            var newNode = new SingleNode(data);
            newNode.next = singleLinkedList.head;
            singleLinkedList.head = newNode;
        }


        internal static void prepend(DoubleLinkedList doubleLinkedList, int data)
        {
            var newNode = new DoubleNode(data);
            newNode.next = doubleLinkedList.head;
            if(doubleLinkedList.head != null)
            {
                doubleLinkedList.head.previous = newNode;
            }
            doubleLinkedList.head = newNode;
        }

        internal static void deleteNodeByData(SingleLinkedList singleLinkedList, int data)
        {
            var tempHead = singleLinkedList.head;
            SingleNode prev = null;

            if(tempHead != null && tempHead.data == data)
            {
                singleLinkedList.head = tempHead.next;
                return;
            }
            while(tempHead != null && tempHead.data != data)
            {
                prev = tempHead;
                tempHead = tempHead.next;
            }
            if(prev == null)
            {
                return;
            }
            prev.next = tempHead.next;
        }

        internal static void deleteNodeByData(DoubleLinkedList doubleLinkedList, int data)
        {
            DoubleNode tempHead = doubleLinkedList.head, prev = null;
            if (tempHead != null && tempHead.data == data)
            {
                doubleLinkedList.head = tempHead.next;
                return;
            }
            while(tempHead != null && tempHead.data != data)
            {
                prev = tempHead;
                tempHead = tempHead.next;
            }
            if(prev == null)
            {
                return;
            }
            prev.next = tempHead.next;
            tempHead.next.previous = prev;

        }

        internal static void getLastNode(SingleLinkedList singleLinkedList)
        {

        }
    }
}
