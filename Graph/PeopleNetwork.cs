using System;
using System.Collections.Generic;

namespace Graph
{
    public class PeopleNetwork
    {
        public PeopleNetwork()
        {
            AdjacencyList = new List<List<int>>();
            Vertices = new List<Person>();
        }


        public List<List<int>> AdjacencyList { get; }
        public List<Person> Vertices { get; }

        public int FindObjectIndex(Person obj)
        {
            return Vertices.FindIndex(x => x.Name == obj.Name);
        }

        public void AddVertex(Person obj)
        {
            Vertices.Add(obj);
            AdjacencyList.Add(new List<int>());
        }

        public bool AddEdge(Person obj1, Person obj2)
        {
            var i = FindObjectIndex(obj1);
            var j = FindObjectIndex(obj2);
            if (i > Vertices.Count - 1 || j > Vertices.Count)
                return false;
            if (!AdjacencyList[i].Contains(j))
                AdjacencyList[i].Add(j);
            if (!AdjacencyList[j].Contains(i))
                AdjacencyList[j].Add(i);
            return true;
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


        //Theis is the BFS
        public int FindDistanceBFS(Person obj1, Person obj2)
        {
            throw new NotImplementedException();
        }


        public static void ReadData(PeopleNetwork network)
        {
            var p1 = new Person("Tomas");
            var p2 = new Person("Amanda");
            var p3 = new Person("Oliver");
            var p4 = new Person("Innes");
            var p5 = new Person("Tamara");
            var p6 = new Person("Jolie");
            var p7 = new Person("Jordan");
            var p8 = new Person("Gigi");
            var p9 = new Person("Clancy");
            var p0 = new Person("Pebbles");

            network.AddVertex(p0);
            network.AddVertex(p1);
            network.AddVertex(p2);
            network.AddVertex(p3);
            network.AddVertex(p4);
            network.AddVertex(p5);
            network.AddVertex(p6);
            network.AddVertex(p7);
            network.AddVertex(p8);
            network.AddVertex(p9);

            network.AddEdge(p1, p2);
            network.AddEdge(p1, p3);
            network.AddEdge(p1, p4);
            network.AddEdge(p1, p5);
            network.AddEdge(p2, p1);
            network.AddEdge(p2, p3);
            network.AddEdge(p2, p6);
            network.AddEdge(p2, p7);
            network.AddEdge(p3, p7);
            network.AddEdge(p3, p4);
            network.AddEdge(p3, p0);
            network.AddEdge(p4, p0);
            network.AddEdge(p6, p9);

        }
    }


    public class Person
    {
        private string name;
        private int idx;
        private bool discovered;
        public string Name { get => name; set => name = value; }
        public int Idx { get => idx; set => idx = value; }
        public bool Discovered { get => discovered; set => discovered = value; }
        public Person(string val)
        {
            name = val;
            discovered = false;
        }
    }



    //public class StackPerson
    //{
    //    public Person person;
    //    public bool discovered = false;
    //}

}
