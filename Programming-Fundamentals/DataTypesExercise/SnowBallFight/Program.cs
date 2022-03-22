using System;
using System.Numerics;

namespace SnowBallFight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bestSnoballSnow = 0;
            int bestSnowBallTIme = 0;
            int bestSnowBallQuality = 0;
            BigInteger bestSnowBallValue = BigInteger.Zero;
            for (int i = 1; i <= n; i++)
            {
                int snowBallSnow = int.Parse(Console.ReadLine());
                int snowBallTime = int.Parse(Console.ReadLine());
                int snowBallQuality = int.Parse(Console.ReadLine());
                int divider = 0;
                divider = snowBallSnow / snowBallTime;
                BigInteger snowBallValue = BigInteger.Pow(divider, snowBallQuality);
                if (snowBallValue >= bestSnowBallValue)
                {
                    bestSnoballSnow = snowBallSnow;
                    bestSnowBallQuality = snowBallQuality;
                    bestSnowBallTIme = snowBallTime;
                    bestSnowBallValue = snowBallValue;
                }
            }
            Console.WriteLine($"{bestSnoballSnow} : {bestSnowBallTIme} = {bestSnowBallValue} ({bestSnowBallQuality})");
        }
    }
}
