using System;
using System.Collections;
using System.Collections.Generic;

namespace Graph
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("GRAPH AND GRAPH TRAVERSAL");
            var network = new Graph();
            network.PrintAdjacencyList();
            network.BFS(0);
            network.DFS(0);

        }
    }
}
