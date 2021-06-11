using System;
using System.Collections;

namespace Orsel.Math.Graph
{
    public enum TypeGraph
    {
        Undirected,
        Directed,
    }

    public class AdjacencyMatrix : GraphStorage
    {
        private BitArray[] matrix;
        
        public AdjacencyMatrix(int vertices, TypeGraph type) : base(vertices, type)
        {
            matrix = new BitArray[Vertices];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new BitArray(Vertices);
            }
        }

        public BitArray GetBitArray(int vertex)
        {
            return matrix[vertex];
        }

        public override void AddEdge(int vertexBegin, int vertexEnd)
        {
            matrix[vertexBegin][vertexEnd] = true;
            if (Type == TypeGraph.Undirected)
            {
                matrix[vertexEnd][vertexBegin] = true;
            }
        }

        public override string ToString()
        {
            string s = String.Empty;
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col])
                    {
                        s += "1 ";
                    }
                    else
                    {
                        s += "0 ";
                    }
                }
                s += Environment.NewLine;
            }
            return s;
        }
    }
}
