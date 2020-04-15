using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Problems
{
    public class RedundantConnection
    {
        //traversal to find duplicate
        /* private bool DFS(int start, int end, Dictionary<int, IList<int>> path, Dictionary<int, bool> visited)
         {
             if (start == end && visited[end])
                 return true;

             visited[start] = true;
             if (!path.ContainsKey(start))
                 return false;

             int vertex = path[start].Count;

             for ( int i = 0; i < vertex; i++)
             {
                 bool result = DFS(path[start][i], end, path, visited);
                 if (result)
                     return result;
             }
             return false;
         }

         public int[] FindRedundantConnection(int[][] edges)
         {
             Dictionary<int, int> nodeDegree = new Dictionary<int, int>();
             int rowCount = edges.Length;

             int[] result = new int[2];

             Dictionary<int, bool> visited = new Dictionary<int, bool>();

             Dictionary<int, IList<int>> dictMatrix = new Dictionary<int, IList<int>>();

             for (int i = 0; i < rowCount; i++)
             {
                 if (!visited.ContainsKey(edges[i][0]))
                     visited.Add(edges[i][0], false);
                 if (!visited.ContainsKey(edges[i][1]))
                     visited.Add(edges[i][1], false);

                 if (nodeDegree.ContainsKey(edges[i][0]))
                     nodeDegree[edges[i][0]]++;
                 else
                     nodeDegree.Add(edges[i][0], 1);

                 if (nodeDegree.ContainsKey(edges[i][1]))
                     nodeDegree[edges[i][1]]++;
                 else
                     nodeDegree.Add(edges[i][1], 1);

                 if (dictMatrix.ContainsKey(edges[i][0]))
                     dictMatrix[edges[i][0]].Add(edges[i][1]);
                 else
                     dictMatrix[edges[i][0]] = new List<int>() { edges[i][1] };

             }

             Dictionary<int, bool> visitedCopy1 = new Dictionary<int, bool>(visited);
             for (int i = rowCount - 1; i >= 0; i--)
             {
                 if (nodeDegree[edges[i][1]] == 1 || nodeDegree[edges[i][0]] == 1)
                     continue;
                 foreach(var entry in visitedCopy1)
                     visited[entry.Key]= false;
                 Dictionary<int, bool> visitedCopy = new Dictionary<int, bool>(visitedCopy1);
                 if (DFS(edges[i][0], edges[i][1], dictMatrix, visitedCopy))
                     return new int[] { edges[i][0], edges[i][1] };
             }

             return result;
         }*/

        //DSU
        public int[] FindRedundantConnection(int[][] edges)
        {
            DisjointSetUnion dsu = new DisjointSetUnion();
            int[] result = new int[2];
            foreach(int[] edge in edges)
            {
                if (dsu.Find(edge[0]) == dsu.Find(edge[1]))
                {
                    result[0] = edge[0];
                    result[1] = edge[1];
                }

                dsu.Union(edge[0], edge[1]);
            }
            return result;
        }
    }
}
