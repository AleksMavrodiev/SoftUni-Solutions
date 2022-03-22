using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split('!', StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                string[] cmdArgs = command.Split();
                string action = cmdArgs[0];
                if (action == "Urgent")
                {
                    string productToInsert = cmdArgs[1];
                    if (shoppingList.Contains(productToInsert))
                    {
                        continue;
                    }
                    else
                    {
                        shoppingList.Insert(0, productToInsert);
                    }
                }
                else if (action == "Unnecessary")
                {
                    string itemToDelete = cmdArgs[1];
                    if (shoppingList.Contains(itemToDelete))
                    {
                        shoppingList.Remove(itemToDelete);
                    }
                    continue;
                }
                else if (action == "Correct")
                {
                    string itemToChange = cmdArgs[1];
                    if (shoppingList.Contains(itemToChange))
                    {
                        string newItem = cmdArgs[2];
                        int indexOfOld = shoppingList.IndexOf(itemToChange);
                        shoppingList[indexOfOld] = newItem;
                    }
                    continue;
                }
                else if (action == "Rearrange")
                {
                    string itemToArrange = cmdArgs[1];
                    if (shoppingList.Contains(itemToArrange))
                    {
                        int indexToArrange = shoppingList.IndexOf(itemToArrange);
                        shoppingList.RemoveAt(indexToArrange);
                        shoppingList.Add(itemToArrange);
                    }
                    continue;
                }
            }
            Console.WriteLine(String.Join(", ", shoppingList));
        }
    }
}
