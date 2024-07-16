using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra_Algoritm.Entities
{
    public class Node
    {
        public Node(string name)
        {
            Name = name;
            Edges = new List<Edge>();
        }

        public string Name { get; set; }
        public List<Edge> Edges { get; set; }

        public void AddEdge(Node targetNode,int weight)
        {
            Edges.Add(new Edge(this, targetNode, weight));
        }

    }
}
