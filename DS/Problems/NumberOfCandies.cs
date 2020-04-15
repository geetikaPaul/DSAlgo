using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Problems
{
    public class NumberOfCandies
    {
        public int[] func(int candies, int num_people)
        {
            int[] result = new int[num_people];
            
            for(int i=1;i<=num_people;i++)
            {
                int j = 0;
                result[i-1] = 0;
                while(true)
                {
                    int x = num_people * j + i;
                    int candiesRequired = x * (x + 1) / 2;
                    int candiesRequiredPrev = (x - 1) * x / 2;
                    if (candies >= candiesRequired)
                        result[i-1] += x;
                    else if(candies < candiesRequired && candies > candiesRequiredPrev)
                        result[i - 1] += (candies - candiesRequiredPrev);
                    else
                        break;
                    j++;
                }
            }

            return result;
        }
    }
}
