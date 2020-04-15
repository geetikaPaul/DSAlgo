using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public static class GraphTester
    {
        public static void Test()
        {
            Graph graph = new Graph(4);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 3);
            graph.AddEdge(1, 4);
            graph.AddEdge(3, 1);
            graph.AddEdge(3, 4);

            //graph.DFS();
            graph.BFS();
        }
    }
}
