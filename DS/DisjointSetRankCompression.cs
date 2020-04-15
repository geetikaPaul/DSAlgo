using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Problems
{
    public class Subset
    {
        public int rank { get; set; }
        public int parent { get; set; }

        public Subset(int p, int r)
        {
            parent = p;
            rank = r;
        }
    }
    public class DisjointSetRankCompression
    {
        public int Find(Subset[] subsets, int x)
        {
            while (subsets[x].parent != x)
                x = subsets[x].parent;
            return x;
        }
        public void Union(Subset[] subsets, int x, int y)
        {
            int parentX = Find(subsets, x);
            int parentY = Find(subsets, y);

            if (subsets[parentX].rank < subsets[parentY].rank)
                subsets[parentX].parent = parentY;
            else if (subsets[parentX].rank > subsets[parentY].rank)
                subsets[parentY].parent = parentX;
            else
            {
                subsets[parentY].parent = parentX;
                subsets[parentX].rank++;
            }
        }
    }
}
