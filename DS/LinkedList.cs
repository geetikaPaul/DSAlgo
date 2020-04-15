using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public class Node
    {
        public Node prev { get; set; }
        public int value { get; set; }
        public Node next { get; set; }
    }
    public class LinkedList
    {
        public Node head { get; set; }

        public LinkedList()
        {
            head = new Node() { next = null, prev = null, value = -1 };
        }

        public void Add(int n)
        {
            Console.WriteLine(string.Format("trying to insert {0}",n));

            Node x = head;
            if (x.next == null)
            {
                x.next = new Node() { next = null, prev = x, value = n };
                return;
            }

            while (x.next != null && x.value < n)
            {
                Console.WriteLine(x.value);
                x = x.next;
            }

            if (x.next == null && x.value < n)
            {
                x.next = new Node() { next = null, prev = x, value = n };
                return;
            }

            Node newNode = new Node() { next = x, prev = x.prev != null ? x.prev : null, value = n };
            x.prev.next = newNode;
            x.prev = newNode;
            Console.WriteLine(string.Format("Value inserted {0}",newNode.value));
        }

        public Node Search(int n)
        {
            Node x = head.next;
            while (x != null && x.value!=n)
            {
                x = x.next;
            }

            return x;
        }

        public void PrintList()
        {
            Node x = head.next;
            while (x != null)
            {
                Console.Write(x.value);
                Console.Write(" ");
                x = x.next;
            }
            Console.WriteLine();
        }
    }
}
