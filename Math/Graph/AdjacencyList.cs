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

        public int GetValue(int row, int col)
        {
            return list[row][col];
        }

        public List<int> GetList(int row)
        {
            return list[row];
        }

        public void SetValue(int row, int col)
        {
            list[row].Add(col);
            if (Type == TypeGraph.Undirected)
            {
                list[col].Add(row);
            }
        }

        public override string ToString()
        {
            string s = String.Empty;
            for (int row = 0; row < list.Length; row++)
            {
                s += $"{row}: ";
                for (int col = 0; col < list[row].Count; col++)
                {
                    s += $"{list[row][col]} ";
                }
                s += Environment.NewLine;
            }
            return s;
        }
    }
}
