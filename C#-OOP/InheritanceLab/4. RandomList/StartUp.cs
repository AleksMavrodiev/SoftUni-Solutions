using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add("Abba");
            list.Add("Muse");
            list.Add("Coldplay");
            list.ForEach(x => Console.WriteLine(x));
            list.RandomString();
            list.ForEach(x => Console.WriteLine(x));
        }
    }
}
