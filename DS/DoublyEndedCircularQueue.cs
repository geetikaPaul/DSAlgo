using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public class DoublyEndedCircularQueue
    {
        public int front;
        public int rear;
        public int[] queue;
        public int size;
        public int count;

        public DoublyEndedCircularQueue()
        {
            size = 100000;
            front = -1;
            rear = size;
            queue = new int[size];
        }

        public DoublyEndedCircularQueue(int s)
        {
            size = s;
            front = -1;
            rear = size;
            queue = new int[size];
        }

        public void PrintQueue()
        {
            for (int i = 0; i < size; i++)
                Console.WriteLine(queue[i]);
        }
        public void EnqueueFront(int val)
        {
            if (count < size)
            {
                front = (front+1)% size;
                queue[front] = val;
                count++;
                if (rear == -1)
                    ++rear;
            }
            else
                Console.WriteLine("overflow");
        }

        public void EnqueueRear(int val)
        {
            if (count < size)
            {
                rear--;
                queue[rear] = val;
                count++;
            }
            else
                Console.WriteLine("overflow");
        }

        public int DequeueFront(ref bool status)
        {
            if (count == 0 || front<0)
            {
                status = false;
                return -1;
            }

            count--;
            return queue[front--];
        }

        public int DequeueRear(ref bool status)
        {
            if (count == 0 || rear == size)
            {
                status = false;
                return -1;
            }

            count--;
            return queue[rear++];
        }

        public int PeekFront(ref bool status)
        {
            if (count == 0 || front < 0)
            {
                status = false;
                return -1;
            }
            
            return queue[front];
        }

        public int PeekRear(ref bool status)
        {
            if (count == 0 || rear == size)
            {
                status = false;
                return -1;
            }

            return queue[rear];
        }
    }
}
