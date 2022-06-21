using System;

namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            DateModifier dateModifier = new DateModifier();
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
            Console.WriteLine(dateModifier.ModifyDate(firstDate, secondDate));
        }
    }
}
