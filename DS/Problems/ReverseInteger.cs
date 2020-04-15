using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Problems
{
    public class ReverseInteger
    {
        public int func(int x)
        {
            /*List<int> digits = new List<int>();
             int number = Math.Abs(x);
             while (number > 0)
             {
                 digits.Add(number % 10);
                 number /= 10;
             }

             int len = digits.Count;

             number = 0;
             for (int i = len - 1; i >= 0; i--)
             {
                 if (digits[i] > 0)
                     number += (Convert.ToInt32(Math.Pow(10, len - 1 - i)) * digits[i]);

             }
             if (x < 0)
                 return number * (-1);
             return number;*/

            int number = 0;
            int y = Math.Abs(x);

            while (y > 0)
            {
                if (number > Int32.MaxValue / 10)
                    return 0;
                number = (number * 10) + (y % 10);
                y /= 10;
            }

            if (x < 0)
                return number * (-1);
            return number;

        }
    }
}
