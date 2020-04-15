using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public class MonkAndPrisonerOfAzkaban
    {
        public void func()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');

            long[] Ain = new long[n];
            for(int i=0;i<n;i++)
                Ain[i] = Convert.ToInt32(input[i]);

            Stack<long> A = new Stack<long>();

            long[] x = new long[n];
            long[] y = new long[n];

            x[0] = -1;
            A.Push(Convert.ToInt32(input[0]));

            for(int i=1;i<n;i++)
            {
                x[i] = -1;

                if (A.Peek() > Ain[i])
                {
                    x[i] = i;
                    A.Push(Ain[i]);
                    continue;
                }

                long prev = i - 1;
                while(prev>=0 && x[prev] > -1)
                {
                    if(Ain[i]<Ain[x[prev]-1])
                    {
                        x[i] = x[prev];
                        break;
                    }
                    prev--;
                }

                A.Push(Ain[i]);
            }

            y[n - 1] = -1;

            for(int i=n-2;i>=0;i--)
            {
                y[i] = -1;                

                if (A.Pop() > Ain[i])
                {
                    y[i] = i+2;
                    continue;
                }

                long next = i + 1;
                while (next < n && y[next] > -1)
                {
                    if (Ain[i] < Ain[y[next] - 1])
                    {
                        y[i] = y[next];
                        break;
                    }
                    next++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                long sum = x[i] + y[i];
                Console.Write(sum+ " ");
            }
        }
    }
}
