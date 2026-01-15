using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Section11;

namespace Algorithms.Tests.Section11
{
    public class GraphTests
    {
        [Fact]
        public void TestAdjacencyListThatIsValid()
        {
            Graph graph = new Graph();

            graph.AddVertex(0);
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddVertex(3);
            graph.AddVertex(4);
            graph.AddVertex(5);
            graph.AddVertex(6);

            graph.AddEdge(3, 1);
            graph.AddEdge(3, 4);
            graph.AddEdge(4, 2);
            graph.AddEdge(4, 5);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 0);
            graph.AddEdge(0, 2);
            graph.AddEdge(6, 5);


            Assert.Equal(new List<int>() { 1, 2 }, graph.AdjacentList[0]);
            Assert.Equal(new List<int>() { 3, 2, 0 }, graph.AdjacentList[1]);
            Assert.Equal(new List<int>() { 4, 1, 0 }, graph.AdjacentList[2]);
            Assert.Equal(new List<int>() { 1, 4 }, graph.AdjacentList[3]);
            Assert.Equal(new List<int>() { 3, 2, 5 }, graph.AdjacentList[4]);
            Assert.Equal(new List<int>() { 4, 6 }, graph.AdjacentList[5]);
            Assert.Equal(new List<int>() { 5 }, graph.AdjacentList[6]);
        }

        [Fact]
        public void TestAdjacencyListThatIsNotValid()
        {
            Graph graph = new Graph();

            graph.AddVertex(0);
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddVertex(3);
            graph.AddVertex(4);
            graph.AddVertex(5);
            graph.AddVertex(6);

            Assert.Throws<ArgumentOutOfRangeException>(() => graph.AddEdge(10, 5));
        }
    }
}
