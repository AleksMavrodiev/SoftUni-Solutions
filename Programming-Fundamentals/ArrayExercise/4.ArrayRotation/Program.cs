using System;
using System.Linq;

namespace _4.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rotationNum = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotationNum; i++)
            {
                int storeOld = arr[0];
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    
                    arr[j] = arr[j + 1];
                    
                }
                arr[arr.Length - 1] = storeOld;
            }
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
