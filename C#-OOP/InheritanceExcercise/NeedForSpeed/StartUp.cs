namespace NeedForSpeed
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SportCar lambo =  new SportCar(250, 50);
            lambo.Drive(5);
            Console.WriteLine(lambo.Fuel);
        }
    }
}
