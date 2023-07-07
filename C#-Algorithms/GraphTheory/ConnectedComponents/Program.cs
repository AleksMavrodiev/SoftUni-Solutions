using System;
using System.Collections.Generic;
using System.Linq;

namespace ConnectedComponents
{
    internal class Program
    {
        private static bool[] visited;
        private static List<int>[] graph;
        static void Main(string[] args)
        {
            int graphSize = int.Parse(Console.ReadLine());
            graph = ReadGraph(graphSize);
            FindGraphConnectedComponents(graphSize);
        }

        private static void DFS(int vertex)
        {
            if (!visited[vertex])
            {
                visited[vertex] = true;
                foreach (var child in graph[vertex])
                {
                    DFS(child);
                }

                Console.Write(" " + vertex);
            }
        }

        private static List<int>[] ReadGraph(int graphSize)
        {
            var graph = new List<int>[graphSize];
            for (int i = 0; i < graphSize; i++)
            {
                graph[i] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            }

            return graph;
        }
        
        private static void FindGraphConnectedComponents(int graphSize)
        {
            visited = new bool[graphSize];
            for (int startNode = 0; startNode < graph.Count(); startNode++)
            {
                if (!visited[startNode])
                {
                    Console.Write("Connected component:");
                    DFS(startNode);
                    Console.WriteLine();
                }
            }
        }
    }
}
