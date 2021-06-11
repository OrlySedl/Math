using System;

namespace Orsel.Math.Graph
{
    public abstract class GraphStorage
    {
        public readonly int Vertices;
        public readonly TypeGraph Type;

        public GraphStorage(int vertices, TypeGraph type)
        {
            Vertices = vertices;
            Type = type;
        }

        public abstract void AddEdge(int vertexBegin, int vertexEnd);
    }
}
