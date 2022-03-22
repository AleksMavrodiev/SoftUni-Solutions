using System;
using System.Collections.Generic;

namespace _2._MinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materials = new Dictionary<string, int>();
            string material = string.Empty;
            while ((material = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (materials.ContainsKey(material))
                {
                    materials[material] += quantity;
                }
                else
                {
                    materials.Add(material, quantity);
                }
            }
            foreach (var matter in materials)
            {
                Console.WriteLine($"{matter.Key} -> {matter.Value}");
            }
        }
    }
}
