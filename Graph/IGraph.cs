using System;
using System.Collections.Generic;

namespace Graph
{
    public interface IGraph<T>
    {
        List<T> Vertices { get; }

        List<List<int>> AdjacencyList { get; }

        int FindObjectIndex(T obj);

        void AddVertex(T obj);

        bool AddEdge(T obj1, T obj2);

        int FindDistanceBFS(T obj1, T obj2);

    }
}
