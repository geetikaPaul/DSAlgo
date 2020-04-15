using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS.Problems
{
    public class AllPathsFromSourceToDestination
    {
        public bool DFS(int key, Dictionary<int, IList<int>> dictMatrix, bool[] visited, int dest)
        {
            if (key == dest)
                return true;

            if (!dictMatrix.ContainsKey(key))
                return false;

            List<int> children = dictMatrix[key].ToList();
            if (children.Contains(key))
                return false;
            int len = children.Count;
            for (int i = 0; i < len; i++)
            {
                if (dictMatrix.ContainsKey(children[i]) &&  dictMatrix[children[i]].ToList().Contains(key))
                    return false;

                if (!visited[children[i]])
                {
                    visited[children[i]] = true;
                    if (!DFS(children[i], dictMatrix, visited, dest))
                        return false;
                }
            }
            return true;

        }
        public bool LeadsToDestination(int n, int[][] edges, int source, int destination)
        {
            Dictionary<int, IList<int>> dictMatrix = new Dictionary<int, IList<int>>();
            int len = edges.Length;
            if (n == 1)
                if (len == 0)
                    return true;
                else
                    return false;

            for (int i = 0; i < len; i++)
            {
                if (dictMatrix.ContainsKey(edges[i][0]))
                    dictMatrix[edges[i][0]].Add(edges[i][1]);
                else
                    dictMatrix[edges[i][0]] = new List<int>() { edges[i][1] };
            }
            if (dictMatrix.ContainsKey(destination) && dictMatrix[destination].ToList().Count > 0)
                return false;

            bool[] visited = new bool[n];
            for (int i = 0; i < n; i++)
                visited[i] = false;
            return DFS(source, dictMatrix, visited, destination);
        }
    }
}
