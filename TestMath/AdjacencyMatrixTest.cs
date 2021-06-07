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
        public void ToString_CreatingEmptyAdjacencyMatrix()
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
    }
}
