using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Problems
{
    public class CircularPermutation
    {
        public void generateGrayarr(int n, ref List<int> grayCode)
        {
            int N = 1 << n;
            for (int i = 0; i < N; i++)
            {
                int x = i ^ (i >> 1);
                grayCode.Add(x);
            }
        }
        public IList<int> func(int n, int start)
        {
            List<int> grayCode = new List<int>();
            generateGrayarr(n, ref grayCode);
            int i = start;
            IList<int> result = new List<int>();
            result.Add(i);
            int startIndex = grayCode.IndexOf(i);
            i = (startIndex + 1) % Convert.ToInt32(Math.Pow(2, n));
            while (i != startIndex)
            {
                result.Add(grayCode[i]);
                i = (i + 1) % Convert.ToInt32(Math.Pow(2, n));
            }
            return result;
        }
    }
}
