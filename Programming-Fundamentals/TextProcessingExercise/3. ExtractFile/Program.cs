using System;
using System.Linq;

namespace _3._ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] directory = Console.ReadLine().Split('\\', StringSplitOptions.RemoveEmptyEntries);
            string[] file = directory.Last().Split('.');
            string fileName = file[0];
            string extension = file[1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
