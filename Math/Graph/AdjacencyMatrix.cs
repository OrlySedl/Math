using System;
using System.Collections;

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
            matrix = new BitArray[vertices];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new BitArray(vertices);
            }
        }

        public bool GetValue(int row, int col)
        {
            return matrix[row][col];
        }

        public void SetValue(int row, int col, bool value)
        {
            matrix[row][col] = value;
            if (Type == TypeGraph.Undirected)
            {
                matrix[col][row] = value;
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
