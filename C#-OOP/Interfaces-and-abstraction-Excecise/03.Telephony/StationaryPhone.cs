using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Telephony
{
    public class StationaryPhone : ICallable
    {
        public string Call(string number)
        {
            foreach (var ch in number)
            {
                if (!char.IsDigit(ch))
                {
                    return "Invalid number!";
                }
            }
            return $"Dialing... {number}";
        }

    }
}
