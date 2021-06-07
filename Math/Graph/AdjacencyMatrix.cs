using System;
using System.Collections;

namespace Orsel.Math.Graph
{
    class AdjacencyMatrix
    {
        private BitArray[] matrix;

        public readonly int Vertices;

        public AdjacencyMatrix(int vertices)
        {
            Vertices = vertices;
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
        }
    }
}
