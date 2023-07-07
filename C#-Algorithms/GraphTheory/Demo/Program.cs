using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    internal class Program
    {
        private static Dictionary<string, List<string>> graph;
        private static Dictionary<string, int> predecessorCount;
        static void Main(string[] args)
        {
            graph = new Dictionary<string, List<string>>();
            predecessorCount = new Dictionary<string, int>();

            int graphSize = int.Parse(Console.ReadLine());
            for (int i = 0; i < graphSize; i++)
            {
                var line = Console.ReadLine().Split(" -> ");
                var node = line[0];
                var children = line[1].Split(", ").ToList();
                graph.Add(node, new List<string>(children));
            }

            GetPredecessorCount();
            Console.Write("Topological sorting: ");
            TopologocalSort();
        }

        private static void GetPredecessorCount()
        {
            foreach (var node in graph)
            {
                var key = node.Key;
                var children = node.Value;

                if (!predecessorCount.ContainsKey(key))
                {
                    predecessorCount.Add(key, 0);
                }

                foreach (var child in children)
                {
                    if (!predecessorCount.ContainsKey(child))
                    {
                        predecessorCount.Add(child, 0);
                    }

                    predecessorCount[child]++;
                }
            }
        }

        private static void TopologocalSort()
        {
            var sorted = new List<string>();
            while (predecessorCount.Count > 0)
            {
                var node = predecessorCount.FirstOrDefault(n => n.Value == 0);

                if (node.Key == null)
                {
                    break;
                }

                DecreasePredecessorCount(node.Key);

                sorted.Add(node.Key);
                predecessorCount.Remove(node.Key);
            }

            if (predecessorCount.Count > 0)
            {
                Console.WriteLine("Invalid topological sorting");
            }
            else
            {
                Console.WriteLine(string.Join(", ", sorted));
            }
        }

        private static void DecreasePredecessorCount(string key)
        {
            var children = graph[key];
            if (children == null)
            {
                return;
            }

            foreach (var child in children) 
            {
                DecreasePredecessorCount(child);
                predecessorCount[child]--;
            }
        }
    }
}
