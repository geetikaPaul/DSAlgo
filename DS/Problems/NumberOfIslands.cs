using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Problems
{
    public class DSU2
    {
        public int[] parent { get; set; }
        public int count { get; set; }
        public DSU2(char[][] grid)
        {
            int rowCount = grid.Length;
            int colCount = grid[0].Length;
            parent = new int[rowCount * colCount];
            count = 0;
            for(int i=0;i<rowCount;i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        parent[i * colCount + j] = i * colCount + j;
                        count++;
                    }
                    else
                        parent[i * colCount + j] = -1;
                }
            }
        }
        public int Find(int x)
        {
            while (parent[x] != x)
                x = parent[x];
            return x;
        }
        public void Union(int x, int y)
        {
            int px = Find(x);
            int py = Find(y);
            if (px != parent[py])
            {
                parent[py] = px;
                count--;
            }
        }
    }
    public class NumberOfIslands
    {
        public int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0)
                return 0;
            DSU2 ds = new DSU2(grid);
            int rowCount = grid.Length;
            int colCount = grid[0].Length;

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        if (i > 0 && grid[i - 1][j] == '1')
                            ds.Union((i * colCount + j), ((i - 1) * colCount + j));
                        if (j > 0 && grid[i][j - 1] == '1')
                            ds.Union((i * colCount + j), (i * colCount + (j - 1)));
                        if (j < colCount - 1 && grid[i][j + 1] == '1')
                            ds.Union((i * colCount + j), (i * colCount + (j + 1)));
                        if (i < rowCount - 1 && grid[i + 1][j] == '1')
                            ds.Union((i * colCount + j), ((i + 1) * colCount + j));
                    }
                }
            }

             return ds.count;
        }
    }
}
