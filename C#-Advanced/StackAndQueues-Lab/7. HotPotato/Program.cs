using System;
using System.Collections.Generic;

namespace _7._HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] players = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(players);
            while (queue.Count > 1)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    string player = queue.Dequeue();
                    queue.Enqueue(player);
                }
                string removedPlayer = queue.Dequeue();
                Console.WriteLine($"Removed {removedPlayer}");
            }
            string lastPLayer = queue.Dequeue();
            Console.WriteLine($"Last is {lastPLayer}");
        }
    }
}
