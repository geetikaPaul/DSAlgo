using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public class DisjointSetUnion
    {
        public int[] arr { get; set; }
        public int size { get; set; }
        public DisjointSetUnion()
        {
            size = 1000;
            arr = new int[1000];
            Initialize();
        }
        public DisjointSetUnion(int s)
        {
            size = s;
            arr = new int[s];
            Initialize();
        }
        public void Initialize()
        {
            for (int i = 0; i < size; i++)
                arr[i] = i;
        }
        public int Find(int x)
        {
            while (arr[x] != x)
                x = arr[x];
            return x;
        }

        public void Union(int x, int y)
        {
            arr[Find(x)] = Find(y);
        }
    }
}
