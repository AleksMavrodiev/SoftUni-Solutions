using System;

namespace _03.Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] urls = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            SmartPhone smartPhone = new SmartPhone();
            ICallable stationaryPhone = new StationaryPhone();
            foreach (var number in numbers)
            {
                if (number.Length > 7)
                {
                    Console.WriteLine(smartPhone.Call(number));
                }
                else
                {
                    Console.WriteLine(stationaryPhone.Call(number));
                }
            }

            foreach (var url in urls)
            {
                Console.WriteLine(smartPhone.Browse(url)); 
            }
        }
    }
}
