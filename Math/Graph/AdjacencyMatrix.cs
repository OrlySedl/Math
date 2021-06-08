using System;
using System.Collections;
using System.Collections.Generic;

namespace Orsel.Math.Graph
{
    public enum TypeGraph
    {
        Undirected,
        Directed,
    }

    public class AdjacencyMatrix
    {
        private BitArray[] matrix;
        
        public readonly int Vertices;
        public readonly TypeGraph Type;

        public AdjacencyMatrix(int vertices, TypeGraph type)
        {
            Vertices = vertices;
            Type = type;
            matrix = new BitArray[Vertices];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new BitArray(Vertices);
            }
        }

        public BitArray GetList(int vertex)
        {
            return matrix[vertex];
        }

        public void AddEdge(int vertexBegin, int vertexEnd)
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
