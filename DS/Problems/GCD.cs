using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Problems
{
    public class GCD
    {
        public int GcdCalc(int a, int b)
        {
            if (a == 0)
                return b;
            return GcdCalc(b % a, a);
        }
    }
}
