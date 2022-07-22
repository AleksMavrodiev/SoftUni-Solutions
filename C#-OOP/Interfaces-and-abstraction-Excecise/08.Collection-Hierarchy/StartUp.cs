using System;

namespace _08.Collection_Hierarchy
{
    internal class Startup
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            int removeCount = int.Parse(Console.ReadLine());
            IAddCollection addCollection = new AddCollection();
            IAddRemoveCollection addRemoveColection = new AddRemoveCollection();
            IMyList myList = new MyList();

            AddToCollection(addCollection, words);
            AddToCollection(addRemoveColection, words);
            AddToCollection(myList, words);

            RemoveFromCollection(addRemoveColection, removeCount);
            RemoveFromCollection(myList, removeCount);
        }

        public static void AddToCollection(IAddCollection items, string[] words)
        {
            foreach (string word in words)
            {
                Console.Write(items.Add(word) + " "); 
            }
            Console.WriteLine();
        }

        public static void RemoveFromCollection(IAddRemoveCollection items, int removeCount)
        {
            for (int i = 0; i < removeCount; i++)
            {
                Console.Write(items.Remove() + " "); 
            }
            Console.WriteLine();
        }
    }
}
