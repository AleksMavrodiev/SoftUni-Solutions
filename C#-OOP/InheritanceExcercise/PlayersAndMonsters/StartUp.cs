namespace PlayersAndMonsters
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            DarkKnight newDark = new DarkKnight("Kratos", 87);
            Console.WriteLine(newDark);
        }
    }
}