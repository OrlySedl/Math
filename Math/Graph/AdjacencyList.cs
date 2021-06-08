using System;
using System.Collections.Generic;

namespace Orsel.Math.Graph
{
    class AdjacencyList
    {
        private List<int>[] list;

        public readonly int Vertices;
        public readonly TypeGraph Type;

        public AdjacencyList(int vertices, TypeGraph type)
        {
            Vertices = vertices;
            Type = type;
            list = new List<int>[Vertices];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = new List<int>();
            }
        }
    }
}
