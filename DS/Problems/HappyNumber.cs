using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Problems
{
    public class HappyNumber
    {
        public bool IsHappy(int n)
        {
            HashSet<int> nums = new HashSet<int>();
            while (true)
            {
                int sum = 0;
                while (n > 0)
                {
                    int d = n % 10;
                    sum += Convert.ToInt32(Math.Pow(d, 2));
                    n = n / 10;
                }

                if (sum == 1)
                    return true;

                if (nums.Contains(sum))
                    return false;

                nums.Add(sum);
                n = sum;
            }
            /*int p1 = n;
            int p2 = squareDigitSum(n);
            while (p2 != 1 && p1 != p2)
            {
                p1 = squareDigitSum(p1);
                p2 = squareDigitSum(squareDigitSum(p2));
            } 

            if(p2==1)
                return true;
            return false;*/
        }

        private int squareDigitSum(int p1)
        {
            int p2 = 0;
            while (p1 > 0)
            {
                int d = p1 % 10;
                p2 += Convert.ToInt32(Math.Pow(d, 2));
                p1 = p1 / 10;
            }
            return p2;
        }
    }
}
