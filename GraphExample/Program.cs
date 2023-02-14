using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphExample
{
    class Graph
    {
        private int numberOfVertices;
        private List<int>[] adjacencyList;

        public Graph(int numberOfVertices)
        {
            this.numberOfVertices = numberOfVertices;
            adjacencyList = new List<int>[numberOfVertices];

            for (int i = 0; i < numberOfVertices; i++)
            {
                adjacencyList[i] = new List<int>();
            }
        }

        public void AddEdge(int source, int destination)
        {
            adjacencyList[source].Add(destination);
        }

        public void PrintGraph()
        {
            Console.WriteLine("Adjacency List Representation of the Graph:");
            for (int i = 0; i < numberOfVertices; i++)
            {
                Console.Write("vertex " + i + " is connected to: ");
                foreach (int j in adjacencyList[i])
                {
                    Console.Write(j + " ");
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
}