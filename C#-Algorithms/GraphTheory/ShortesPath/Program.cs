using System;
using System.Collections.Generic;
using System.Linq;

namespace ShortesPath
{
    internal class Program
    {
        private static List<int>[] graph;
        private static bool[] visited;
        private static int[] parent;
        static void Main(string[] args)
        {
            int nodesNum = int.Parse(Console.ReadLine());
            int edgesNum = int.Parse(Console.ReadLine());

            graph = new List<int>[nodesNum + 1];
            visited = new bool[graph.Length];
            parent = new int[graph.Length];

            Array.Fill(parent, -1);

            for (int node = 0; node < graph.Length; node++)
            {
                graph[node] = new List<int>();
            }

            for (int i = 0; i < edgesNum; i++)
            {
                var edge = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var firstNode = edge[0];
                var secondNode = edge[1];
                graph[firstNode].Add(secondNode);
                graph[secondNode].Add(firstNode);
            }

            var start = int.Parse(Console.ReadLine());
            var destination = int.Parse(Console.ReadLine());

            Bfs(start, destination);

        }

        

        private static void Bfs(int startNode, int destination)
        {
            var queue = new Queue<int>();
            queue.Enqueue(startNode);

            visited[startNode] = true;

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                if (node == destination)
                {
                    var path = GetPath(destination);
                    Console.WriteLine($"Shortest path length is: {path.Count - 1}");
                    Console.WriteLine(string.Join(" ", path));
                    break;
                }

                foreach (var child in graph[node])
                {
                    if (!visited[child])
                    {
                        parent[child] = node;
                        visited[child] = true;
                        queue.Enqueue(child);
                    }
                }
            }
        }

        private static Stack<int> GetPath(int destination)
        {
            var path = new Stack<int>();
            var index = destination;

            while (index != -1)
            {
                path.Push(index);
                index = parent[index];
            }

            return path;
        }
    }
}
