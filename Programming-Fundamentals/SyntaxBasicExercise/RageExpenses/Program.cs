using System;

namespace RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            bool isHeadsetCrashed = false;
            bool isMouseCrashed = false;
            bool isKeyboardCrashed = false;
            int keyboardCounter = 0;
            double total = 0;
            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    isHeadsetCrashed = true;
                    total += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    isMouseCrashed = true;
                    total += mousePrice;
                }
                if (isHeadsetCrashed && isMouseCrashed)
                {
                    keyboardCounter++;
                    isKeyboardCrashed = true;
                    total += keyboardPrice;
                }
                if (isKeyboardCrashed && keyboardCounter % 2 == 0)
                {
                    total += displayPrice;
                }
                isHeadsetCrashed = false;
                isMouseCrashed = false;
                isKeyboardCrashed = false;
            }
            Console.WriteLine($"Rage expenses: {total:F2} lv.");
        }
    }
}
