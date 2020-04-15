using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public class Queue
    {
        private int[] queueArray { get; set; }
        private int head { get; set; }
        private int tail { get; set; }
        private int maxLength { get; set; }

        public Queue()
        {
            maxLength = 100;
            head = -1;
            tail = 0;
            queueArray = new int[maxLength];
        }

        public void Enqueue(int n)
        {
            if (tail == maxLength - 1)
                Console.WriteLine("Queue overflow");
            queueArray[tail++] = n;
            if (head == -1)
                head++;
        }

        public int Dequeue()
        {
            if(head==tail)
            {
                Console.WriteLine("Queue Underflow");
                return -1;
            }
            return queueArray[head++];
        }

        public void PrintQueue()
        {
            for (int i = head; i < tail; i++)
            {
                Console.Write(queueArray[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
