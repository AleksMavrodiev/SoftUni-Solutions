using System;
using System.Collections.Generic;

namespace CryptoExchange
{
    internal class Program
    {
        private static Dictionary<string, List<string>> graph;

        static void Main(string[] args)
        {
            int pairs = int.Parse(Console.ReadLine());
            graph = new Dictionary<string, List<string>>();
            for (int i = 0; i < pairs; i++)
            {
                var pair = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                var first = pair[0];
                var second = pair[1];
                if (!graph.ContainsKey(first))
                {
                    graph.Add(first, new List<string>());
                }

                if (!graph.ContainsKey(second))
                {
                    graph.Add(second, new List<string>());
                }
                graph[first].Add(second);
                graph[second].Add(first);
            }

            var line = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            var start = line[0];
            var end = line[1];

            var result = BFS(start, end);
            Console.WriteLine(result);
        }

        private static int BFS(string start, string end)
        {
            var queue = new Queue<string>();
            queue.Enqueue(start);

            var visited = new HashSet<string>{ start };
            var steps = new Dictionary<string, int> { { start, 0 } };

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (node == end)
                {
                    return steps[node];
                }

                foreach (var child in graph[node])
                {
                    if (!visited.Contains(child))
                    {
                        queue.Enqueue(child);
                        visited.Add(child);
                        steps[child] = steps[node] + 1;
                    }
                }
            }

            return -1;
        }
    }
}
