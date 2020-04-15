using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Problems
{
    public class PrimePalindrome
    {
        public int PalindromeGenerator(int n)
        {
            List<int> digits = new List<int>();
            int number = n;
            while(number>0)
            {
                digits.Add(number % 10);
                number /= 10;
            }

            digits.Reverse();
            int len = digits.Count;

            if (n == 9 || n==10)
                return 11;

            if (n == 99)
                return 101;

            if (len == 1)
                return n + 1;

            if (len % 2 == 0)
            {

                int i = len / 2 - 1;
                digits[i] += 1;
                if (digits[i] == 10)
                    digits[i] = 0;
                digits[len - 1 - i] = digits[i];
                while ( i > 0)
                {
                    if (digits[i--] > 0)
                        digits[len - 1 - i] = digits[i];
                    else
                    {
                        digits[i] += 1;
                        if (digits[i] == 10)
                            digits[len - 1 - i] = 1;
                        else
                         digits[len - 1 - i] = digits[i];
                    }
                }

               
            }
            else
            {
                int i = len / 2;
                digits[i] += 1;
                if (digits[i] == 10)
                    digits[i] = 0;

                while (i > 0)
                {
                    if (digits[i--] > 0)
                        digits[len - 1 - i] = digits[i];
                    else
                    {
                        digits[i] += 1;
                        if (digits[i] == 10)
                            digits[len - 1 - i] = 1;
                        else
                            digits[len - 1 - i] = digits[i];
                    }

                }
            }

            number = 0;
            for (int i = len - 1; i >= 0; i--)
                number += (Convert.ToInt32(Math.Pow(10, len-1-i)) * digits[i]);

            return number;
        }
        public int PrimePalindromeCalc(int N)
        {

            int palindrome = N;
            while (true)
            {
                List<int> digits = new List<int>();
                int number = palindrome;

                while (number > 0)
                {
                    digits.Add(number % 10);
                    number /= 10;
                }
                int len = digits.Count;
                int j = 0;
                for (; j < len / 2; j++)
                    if (digits[j] != digits[len - 1 - j])
                        break;

                if(j < len/2)
                    palindrome = PalindromeGenerator(palindrome);

                int sqrtPal = Convert.ToInt32(Math.Sqrt(palindrome));
                int i = 2;
                for (; i <= sqrtPal; i++)
                    if (palindrome % i == 0)
                        break;
                if (i > sqrtPal)
                    return palindrome;

                palindrome = PalindromeGenerator(palindrome);
            }
        }
    }
}
