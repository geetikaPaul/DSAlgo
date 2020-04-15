using System;
using System.Collections.Generic;
using System.Text;

namespace DS.Problems
{
    public class TimeNeededToInform
    {
        public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime)
        {
            /*int result = informTime[headID];
            Queue<int> superior = new Queue<int>();
            int employeesInformed = 1;

            superior.Enqueue(headID);

            while (employeesInformed < n)
            {
                List<int> subordiantes = new List<int>();
                while (superior.Count > 0)
                {
                    int head = superior.Dequeue();
                    int startIndex = 0;
                    int prev = -1;
                    while (true)
                    {
                        int s = Array.IndexOf(manager, head, startIndex);
                        if (prev == s)
                            break;
                        subordiantes.Add(s);
                        employeesInformed++;
                        startIndex = s + 1;
                    }
                }

                int maximumTime = -1;
                foreach (int s in subordiantes)
                {
                    superior.Enqueue(s);
                     if (informTime[s] > maximumTime)
                        maximumTime = informTime[s];
                }
                if(maximumTime>-1)
                    result += maximumTime;
            }


            return result;*/

            //DFS
            int result = 0;
            Dictionary<int, IList<int>> hierarchy = new Dictionary<int, IList<int>>();
            for (int i = 0; i < n; i++)
            {
                if (hierarchy.ContainsKey(manager[i]))
                    hierarchy[manager[i]].Add(i);
                else
                    hierarchy.Add(manager[i], new List<int>() { i });                
            }
            bool[] visited = new bool[n];
            for (int i = 0; i < n; i++)
                visited[i] = false;
            
            DFS(headID, hierarchy, visited, ref result, informTime, 0);
            return result;
        }

        private void DFS(int start, Dictionary<int, IList<int>> hierarchy, bool[] visited, ref int maxSum, int[] informTime, int sum)
        {
            visited[start] = true;

            if (!hierarchy.ContainsKey(start))
                return;
            sum += informTime[start];
            if (sum > maxSum)
                maxSum = sum;
            int vertex = hierarchy[start].Count;
            for (int i = 0; i < vertex; i++)
            {
                if (!visited[hierarchy[start][i]])
                {
                    DFS(hierarchy[start][i], hierarchy, visited, ref maxSum, informTime, sum);
                }

            }
        }
    }
}
