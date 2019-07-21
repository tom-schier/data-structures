using System;
using System.Collections.Generic;
using System.Numerics;

namespace GraphTraversal
{
    class Program
    {
        static void Main(string[] args)
        {

            var ex = new GraphTraversal();
            ex.Bfs(2);
            Console.WriteLine("Graph traversal");
        }
    }

    public class GraphTraversal
    {
        public Matrix5x5  Graph;

        public GraphTraversal()
        {
            Graph = new Dictionary<int,int> {
                {0,1,1,1,0},    
                {0,0,1,0,0},
                {1,1,0,0,0},
                {0,0,0,1,0},
                {0,1,0,0,0}};
        }

        //output key,value pair for node / distance from root
        public void Bfs(int node)
        {
            var nodesLen = new int?[Graph.Length];
            Graph
            int[] queue = { Graph[node, 0], Graph[node, 1], Graph[node, 2], Graph[node, 3], Graph[node, 4] };
            nodesLen[node] = 0;
            int current;
            while(queue.Length != 0)
            {
                
            }
        }
    }
}
,,