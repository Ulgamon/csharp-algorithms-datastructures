using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Section11
{
    public class Graph
    {

        public List<List<int>> AdjacentList { get; set; } = new List<List<int>>();

        public Graph()
        {
            AdjacentList = new List<List<int>>();
        }

        public void AddVertex(int vertex)
        {
            if (vertex < AdjacentList.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            AdjacentList.Add(new List<int>());

        }

        public void AddEdge(int vertex1, int vertex2)
        {
            if (vertex1 >= AdjacentList.Count && vertex2 >= AdjacentList.Count && vertex1 == vertex2 && AdjacentList.Count == 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            AdjacentList[vertex1].Add(vertex2);

            AdjacentList[vertex2].Add(vertex1);

        }
    }
}
