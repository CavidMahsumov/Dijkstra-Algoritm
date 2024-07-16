using Dijkstra_Algoritm.Entities;

class Program
{
    static void Main(string[] args)
    {
        var graph = new Graph();

        var nodeA = new Node("A");
        var nodeB = new Node("B");
        var nodeC = new Node("C");
        var nodeD = new Node("D");
        var nodeE = new Node("E");

        nodeA.AddEdge(nodeB, 4);
        nodeA.AddEdge(nodeC, 2);
        nodeB.AddEdge(nodeC, 5);
        nodeB.AddEdge(nodeD, 10);
        nodeC.AddEdge(nodeE, 3);
        nodeD.AddEdge(nodeE, 4);

        graph.AddNode(nodeA);
        graph.AddNode(nodeB);
        graph.AddNode(nodeC);
        graph.AddNode(nodeD);
        graph.AddNode(nodeE);

        var distances = Dijkstra.FindShortestPath(graph, nodeA);

        foreach (var distance in distances)
        {
            Console.WriteLine($"Distance from {nodeA.Name} to {distance.Key.Name} is {distance.Value}");
        }
    }
}
