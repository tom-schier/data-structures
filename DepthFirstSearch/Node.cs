using System;
using System.Collections.Generic;

namespace DepthFirstSearch
{
    public class Graph
    {
        private Dictionary<int, Node> nodeLookup = new Dictionary<int, Node>();

        private Node getNode(int id)
        {
            return null;
        }

        public void addEdge(int source, int destination)
        {

        }

    }

    public class Node
    {
        private int id;
        LinkedList<Node> adjacent = new LinkedList<Node>();

        public Node(int id)
        {
            this.id = id;
        }
    }
}
