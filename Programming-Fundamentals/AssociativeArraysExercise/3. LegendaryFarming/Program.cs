using System;
using System.Collections.Generic;

namespace _3._LegendaryFarming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>
            {
                {"shards", 0 },
                {"motes", 0 },
                {"fragments", 0 }
            };
            Dictionary<string, int> junk = new Dictionary<string, int>();
            Dictionary<string, string> craftingTable = new Dictionary<string, string> 
            {
                {"shards", "Shadowmourne" },
                {"fragments", "Valanyr" },
                {"motes", "Dragonwrath" }
            };
            string itemObtained = string.Empty;
            while (itemObtained == string.Empty)
            {
                string[] materials = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < materials.Length; i += 2)
                {
                    int quantity = int.Parse(materials[i]);
                    string materialName = materials[i + 1].ToLower();
                    if (keyMaterials.ContainsKey(materialName))
                    {
                        keyMaterials[materialName] += quantity;
                        if (keyMaterials[materialName] >= 250)
                        {
                            keyMaterials[materialName] -= 250;
                            itemObtained = craftingTable[materialName];
                            Console.WriteLine($"{itemObtained} obtained!");
                            break;
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(materialName))
                        {
                            junk[materialName] += quantity;
                        }
                        else
                        {
                            junk.Add(materialName, quantity);
                        }
                    }
                }
            }
            foreach (var item in keyMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
