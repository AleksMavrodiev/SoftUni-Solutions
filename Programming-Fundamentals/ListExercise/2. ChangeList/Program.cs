using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmd = command.Split();
                string action = cmd[0];
                if (action == "Delete")
                {
                    int numberToDelete = int.Parse(cmd[1]);
                    numbers.RemoveAll(x => x == numberToDelete);
                }
                else
                {
                    int numberToInsert = int.Parse(cmd[1]);
                    int indexToInsert = int.Parse(cmd[2]);
                    numbers.Insert(indexToInsert, numberToInsert);
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
