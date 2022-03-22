using System;

namespace PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studenCount = int.Parse(Console.ReadLine());
            double lightSaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            double lightSaberCount = Math.Ceiling(studenCount * 1.1);
            int freeBelts = studenCount / 6;
            double total = (lightSaberCount * lightSaberPrice) + (robePrice * studenCount) + (beltPrice * studenCount) - (freeBelts * beltPrice);
            if (money >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {total - money:F2}lv more.");
            }
        }
    }
}
