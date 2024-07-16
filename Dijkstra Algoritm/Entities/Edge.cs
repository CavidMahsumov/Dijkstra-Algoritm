using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra_Algoritm.Entities
{
    public class Edge
    {
        public Edge(Node startNode, Node endNode, int weight)
        {
            StartNode = startNode;
            EndNode = endNode;
            Weight = weight;
        }

        public Node StartNode { get; set; }
        public Node EndNode { get; set; }
        public int Weight { get; set; }
    }
}
