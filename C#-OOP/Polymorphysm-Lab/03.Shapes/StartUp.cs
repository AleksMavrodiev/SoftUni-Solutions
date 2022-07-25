using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(3.4);
            Rectangle rectangle = new Rectangle(4, 5);
            Console.WriteLine(circle.Draw());
            Console.WriteLine(rectangle.Draw());
            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.CalculateArea());
        }
    }
}
