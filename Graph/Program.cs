using System;
using System.Collections.Generic;

class Graph
{
    private int vertices;
    private List<int>[] adjacencyList;

    public Graph(int vertices)
    {
        this.vertices = vertices;
        adjacencyList = new List<int>[vertices];
        for (int i = 0; i < vertices; i++)
        {
            adjacencyList[i] = new List<int>();
        }
    }

    public void AddEdge(int source, int destination)
    {
        adjacencyList[source].Add(destination);
        adjacencyList[destination].Add(source);
    }

    public void PrintGraph()
    {
        for (int i = 0; i < vertices; i++)
        {
            Console.WriteLine("Adjacency list of vertex " + i);
            Console.Write("head");
            foreach (int vertex in adjacencyList[i])
            {
                Console.Write(" -> " + vertex);
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Graph graph = new Graph(5);
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 4);
        graph.AddEdge(1, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(1, 4);
        graph.AddEdge(2, 3);
        graph.AddEdge(3, 4);
        graph.PrintGraph();
        Console.ReadLine();
    }
}
