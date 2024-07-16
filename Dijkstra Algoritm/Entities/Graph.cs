using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra_Algoritm.Entities
{
    public class Graph
    {
        public List<Node> Nodes { get; set; }

        public Graph()
        {
            Nodes = new List<Node>();
        }
        public void AddNode(Node node)
        {
           Nodes.Add(node);
        }
    }
}
