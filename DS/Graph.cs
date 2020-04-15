using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public class Graph
    {
        public int vertex { get; set; }
        public bool[][] path { get; set; }

        public Graph(int v)
        {
            vertex = v;
            path = new bool[v][];

            for(int i=0;i<v;i++)
            {
                path[i] = new bool[v];
                for(int j=0;j<v;j++)
                {
                    path[i][j] = false;
                }
            }
        }

        public void AddEdge(int v1, int v2)
        {
            path[v1-1][v2-1] = true;
        }

        public void DFS()
        {
            bool[] visited = new bool[vertex];
            for (int i = 0; i < vertex; i++)
                visited[i] = false;
            DFS(0, visited);
        }

        private void DFS(int start, bool[] visited)
        {
            Console.WriteLine(start+1);
            visited[start] = true;

            for(int i=0;i<vertex;i++)
            {
                if (path[start][i] && !visited[i])
                    DFS(i, visited);
            }
        }

        public void BFS()
        {

            bool[] visited = new bool[vertex];
            for (int i = 0; i < vertex; i++)
                visited[i] = false;
            BFS(0, visited);
        }

        private void BFS(int start, bool[] visited)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);

            while(queue.Count>0)
            {
                int cur = queue.Dequeue();
                Console.WriteLine(cur + 1);
                visited[cur] = true;

                for (int i = 0; i < vertex; i++)
                {
                    if (path[cur][i] && !visited[i])
                        queue.Enqueue(i);
                }

            }
        }
    }
}
