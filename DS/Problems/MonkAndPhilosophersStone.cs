using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public class MonkAndPhilosophersStone
    {
        public void func()
        {
            Stack<int> coins = new Stack<int>();
            int n = Convert.ToInt32(Console.ReadLine());
            int[] coinsInput = new int[n];
            string[] coinsStr = Console.ReadLine().Split(' ');
            for (int i=0;i<n;i++)
            {
                coinsInput[i] = Convert.ToInt32(coinsStr[i]);
            }
            string[] qx = Console.ReadLine().Split(' ');
            int q = Convert.ToInt32(qx[0]);
            int x = Convert.ToInt32(qx[1]);

            int sum = 0;
            int index = 0;
            int noOfCoins = 0;

            while(q>0)
            {
                q--;
                string inq = Console.ReadLine();

                if (inq.Equals("Harry"))
                {

                    sum += coinsInput[index];
                    noOfCoins += 1;
                    coins.Push(coinsInput[index++]);
                }
                else if (inq.Equals("Remove"))
                {
                    noOfCoins -= 1;
                    sum -= (coins.Pop());
                }

                if (sum == x)
                {
                    Console.WriteLine(noOfCoins);
                    break;
                }
            }

        }
    }
}
