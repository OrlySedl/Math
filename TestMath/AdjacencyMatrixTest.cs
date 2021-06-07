using Microsoft.VisualStudio.TestTools.UnitTesting;
using Orsel.Math.Graph;

namespace TestMath
{
    [TestClass]
    public class AdjacencyMatrixTest
    {
        [TestMethod]
        public void Vertices_CreationWith4Vertices_4()
        {
            int expected = 4;
            AdjacencyMatrix am = new AdjacencyMatrix(expected, TypeGraph.Undirected);

            Assert.AreEqual(expected, am.Vertices);
        }

        [TestMethod]
        public void Type_CreationWithTypeGraphDirected_Directed()
        {
            TypeGraph expected = TypeGraph.Directed;
            AdjacencyMatrix am = new AdjacencyMatrix(2, expected);

            Assert.AreEqual(expected, am.Type);
        }

        [TestMethod]
        public void SetValue_GetValue_SetTrueInRow1Column0UndirectedGraph_true_true()
        {
            int vertices = 2;
            int row = 1;
            int col = 0;
            AdjacencyMatrix am = new AdjacencyMatrix(vertices, TypeGraph.Undirected);
            am.SetValue(row, col, true);

            Assert.IsTrue(am.GetValue(row, col));
            Assert.IsTrue(am.GetValue(col, row));
        }

        [TestMethod]
        public void SetValue_GetValue_SetTrueInRow0Column1DirectedGraph_true_false()
        {
            int vertices = 2;
            int row = 0;
            int col = 1;
            AdjacencyMatrix am = new AdjacencyMatrix(vertices, TypeGraph.Directed);
            am.SetValue(row, col, true);

            Assert.IsTrue(am.GetValue(row, col));
            Assert.IsFalse(am.GetValue(col, row));
        }

        [TestMethod]
        public void ToString_CreatingEmptyAdjacencyMatrix_string()
        {
            string expected = string.Empty;
            int vertices = 2;
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    expected += "0 ";
                }
                expected += System.Environment.NewLine;
            }
            AdjacencyMatrix am = new AdjacencyMatrix(vertices, TypeGraph.Undirected);

            Assert.AreEqual(expected, am.ToString());
        }

        [TestMethod]
        public void ToString_CreatingFilledAdjacencyMatrix_string()
        {
            string expected = string.Empty;
            int vertices = 2;
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                {
                    expected += "1 ";
                }
                expected += System.Environment.NewLine;
            }
            AdjacencyMatrix am = new AdjacencyMatrix(vertices, TypeGraph.Undirected);
            am.SetValue(0, 0, true);
            am.SetValue(0, 1, true);
            am.SetValue(1, 1, true);

            Assert.AreEqual(expected, am.ToString());
        }
    }
}
