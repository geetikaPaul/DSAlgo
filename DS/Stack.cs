using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public class Stack
    {
        private int[] stackArray { get; set; }
        private int top { get; set; }
        private int maxLength { get; set; }

        public Stack()
        {
            maxLength = 100;
            stackArray = new int[maxLength];
            top = 0;
        }
        public void Push(int n)
        {
            if (top == maxLength - 1)
                Console.WriteLine("stack overflow");
            stackArray[top++] = n;

        }

        public int Pop()
        {
            if (top == 0)
            {
                Console.WriteLine("stack underflow");
                return -1;
            }
            return stackArray[--top];
        }

        public int TopElement()
        {
            if (top == 0)
            {
                Console.WriteLine("stack empty");
                return -1;
            }
            return stackArray[top-1];
        }

        public void PrintStack()
        {
            for(int i=0;i<top;i++)
            {
                Console.Write(stackArray[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
