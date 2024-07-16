using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra_Algoritm.Entities
{
    public class Dijkstra
    {
        public static Dictionary<Node, int> FindShortestPath(Graph graph, Node startNode)
        {
            var distances = new Dictionary<Node, int>();
            var previousNodes = new Dictionary<Node, Node>();
            var unvisitedNodes = new List<Node>();

            // Initialize distances and previous nodes
            foreach (var node in graph.Nodes)
            {
                distances[node] = int.MaxValue;
                previousNodes[node] = null;
                unvisitedNodes.Add(node);
            }
            distances[startNode] = 0;

            while (unvisitedNodes.Count > 0)
            {
                // Get the node with the smallest distance
                var currentNode = unvisitedNodes.OrderBy(node => distances[node]).First();
                unvisitedNodes.Remove(currentNode);

                foreach (var edge in currentNode.Edges)
                {
                    var neighbor = edge.EndNode;
                    var newDist = distances[currentNode] + edge.Weight;

                    if (newDist < distances[neighbor])
                    {
                        distances[neighbor] = newDist;
                        previousNodes[neighbor] = currentNode;
                    }
                }
            }

            return distances;
        }
    }

}
