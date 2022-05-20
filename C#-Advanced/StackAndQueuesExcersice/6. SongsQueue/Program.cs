using System;
using System.Collections.Generic;

namespace _6._SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Queue<string> songQueue = new Queue<string>(input);
            while (songQueue.Count > 0)
            {
                string command = Console.ReadLine();
                if (command.StartsWith("Add"))
                {
                    string songToAdd = command.Substring(4);
                    if (songQueue.Contains(songToAdd))
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                    else
                    {
                        songQueue.Enqueue(songToAdd);
                    }
                }
                else if (command == "Play")
                {
                    songQueue.Dequeue();
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songQueue));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
