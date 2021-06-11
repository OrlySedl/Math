using System;
using System.Collections;

namespace Orsel.Math.Graph
{
    public class Graph
    {
        private GraphStorage storage;

        public Graph(GraphStorage storage)
        {
            this.storage = storage;
        }

        private void DFSAdjacencyMatrix(AdjacencyMatrix am, int node, bool[] visited)
        {
            visited[node] = true;
            Console.WriteLine(node);
            BitArray list = am.GetBitArray(node);
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] && !visited[i])
                {
                    DFSAdjacencyMatrix(am, i, visited);
                }
            }
        }

        private void DFSAdjacencyList(AdjacencyList al, int node, bool[] visited)
        {
            visited[node] = true;
            Console.WriteLine(node);
            foreach (int v in al.GetList(node))
            {
                if (!visited[v])
                {
                    DFSAdjacencyList(al, v, visited);
                }
            }
        }

        public void AddEdge(int vertexBegin, int vertexEnd)
        {
            storage.AddEdge(vertexBegin, vertexEnd);
        }

        // Depth-first search
        public void DFS(int node)
        {
            bool[] visited = new bool[storage.Vertices];
            if (storage is AdjacencyMatrix)
            {
                AdjacencyMatrix am = (AdjacencyMatrix)storage;
                DFSAdjacencyMatrix(am, node, visited);
            }
            if (storage is AdjacencyList)
            {
                AdjacencyList al = (AdjacencyList)storage;
                DFSAdjacencyList(al, node, visited);
            }
        }
    }
}
