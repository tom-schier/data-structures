using System;
using System.Collections;
using System.Collections.Generic;

namespace Graph
{
    public class Graph: IGraph<int>
    {
        private List<int> vertices;
        private List<List<int>> adjacencyList;

        public Graph()
        {
            vertices = new List<int> { 0, 1, 2, 3, 4, 5 };
            adjacencyList = new List<List<int>> {
               new List<int> {1,2},
               new List<int> {4,5},
               new List<int> {3,5},
               new List<int> {0},
               new List<int> {},
               new List<int> {}
            };
        }

        public List<int> Vertices => vertices;

        public List<List<int>> AdjacencyList => adjacencyList;

        public bool AddEdge(int obj1, int obj2)
        {
            var idx = vertices.FindIndex(x => x == obj1);
            if (idx == -1) return false;

            adjacencyList[obj1].Add(obj2);
            adjacencyList[obj2].Add(obj1);
            return true;
        }

        public void AddVertex(int obj)
        {
            vertices.Add(obj);
        }

        public void BFS(int startNode)
        {
            var nodeLen = new List<int>();
            var searchQueue = new Queue<int>();
            searchQueue.Enqueue(startNode);

            var visitedList = new List<int>();

            while(searchQueue.Count > 0)
            {
                var current = searchQueue.Dequeue();
                var index = visitedList.FindIndex(x => x == current);
                if (index > -1)
                    continue;
                visitedList.Add(current);
                Console.WriteLine("BFS: Visited " + current);
                List<int> currentConnected = adjacencyList[current];

                foreach(var col in currentConnected)
                {                  
                    var idx = visitedList.FindIndex(x => x == col);                      
                    if (idx == -1)
                    {                      
                        searchQueue.Enqueue(col);
                    }

                }
            }
                
        }


        public void DFS(int startNode)
        {
            var nodeLen = new List<int>();
            var searchStack = new Stack<int>();
            var visitedList = new List<int>();

            searchStack.Push(startNode);


            while(searchStack.Count > 0)
            {
                var visit = searchStack.Pop();
                visitedList.Add(visit);
                Console.WriteLine("DFS : Visited " + visit);
                var currentConnected = adjacencyList[visit];
                foreach(var item in currentConnected)
                {
                    if (visitedList.FindIndex(x => x == item) == -1)
                        searchStack.Push(item);
                }
            }

        }

        public int FindDistanceBFS(int obj1, int obj2)
        {
            throw new NotImplementedException();
        }

        public int FindObjectIndex(int obj)
        {
            return vertices.FindIndex(x => x == obj);
        }


        public void PrintAdjacencyList()
        {
            int i = 0;

            foreach (var list in AdjacencyList)
            {
                Console.Write("adjacencyList[" + i + "] -> ");

                foreach (var edge in list)
                {
                    Console.Write(" (" + edge + ") ");
                }

                ++i;
                Console.WriteLine();
            }
        }

    }

}
