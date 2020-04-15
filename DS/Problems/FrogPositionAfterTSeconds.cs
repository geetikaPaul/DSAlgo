using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Problems
{
    public class FrogPositionAfterTSeconds
    {
        public double FrogPosition(int n, int[][] edges, int t, int target)
        {
            double result = 1.0;
            Dictionary<int, IList<int>> dict = new Dictionary<int, IList<int>>();
            for (int i = 0; i < n-1; i++)
            {
                if (edges[i][0] < edges[i][1])
                {
                    if (dict.ContainsKey(edges[i][0]))
                        dict[edges[i][0]].Add(edges[i][1]);
                    else
                        dict.Add(edges[i][0], new List<int>() { edges[i][1] });
                }
                else
                {
                    if (dict.ContainsKey(edges[i][1]))
                        dict[edges[i][1]].Add(edges[i][0]);
                    else
                        dict.Add(edges[i][1], new List<int>() { edges[i][0] });
                }
            }
            bool[] visited = new bool[n+1];
            for (int i = 1; i <= n; i++)
                visited[i] = false;
            int timeLimit = 0;
            DFS(1, dict, ref result, visited, target, ref timeLimit);
            if(timeLimit>t)
                return 0.0;
            if (timeLimit < t && dict.ContainsKey(target))
                return 0.0;

            return result;
        }

        public bool DFS(int start, Dictionary<int, IList<int>> dict, ref double result, bool[] visited, int target, ref int timeLimit)
        {
            if(start == target)
            {
                return true;
            }

            if (!dict.ContainsKey(start))
                return false;

            int vertex = dict[start].Count;
            for (int i = 0; i < vertex; i++)
            {
                if (!visited[dict[start][i]])
                    if (DFS(dict[start][i], dict, ref result, visited, target, ref timeLimit))
                    {
                        timeLimit++;
                        result = result * Convert.ToDouble(1 / (dict[start].Count * 1.0));
                        return true;
                    }
            }

            return false;
        }
    }
}
