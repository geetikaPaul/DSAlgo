using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public class DSUTester
    {
        public void Test()
        {
            DisjointSetUnion dsu = new DisjointSetUnion();
            dsu.Union(1, 2);

            Console.WriteLine(dsu.Find(2));
            Console.WriteLine(dsu.Find(1));

            dsu.Union(3, 2);

            Console.WriteLine(dsu.Find(3));
            Console.WriteLine(dsu.Find(2));
            Console.WriteLine(dsu.Find(1));

            if (dsu.Find(1) == dsu.Find(3))
                Console.WriteLine("redundant");
            dsu.Union(1, 3);

            Console.WriteLine("after adding 1-3");

            Console.WriteLine(dsu.Find(3));
            Console.WriteLine(dsu.Find(2));
            Console.WriteLine(dsu.Find(1));

            /*dsu.Union(4, 5);
            Console.WriteLine(dsu.Find(4));
            Console.WriteLine(dsu.Find(2));*/
        }
    }
}
