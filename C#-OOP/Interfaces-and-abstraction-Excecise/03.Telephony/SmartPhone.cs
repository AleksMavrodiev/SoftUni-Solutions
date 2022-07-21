using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Telephony
{
    public class SmartPhone : ICallable, IBrowsable
    {

        public string Browse(string url)
        {
            foreach (var ch in url)
            {
                if (char.IsDigit(ch))
                {
                    return "Invalid URL!";
                }
            }
            return $"Browsing: {url}!";
        }

        public string Call(string number)
        {
            foreach (var ch in number)
            {
                if (!char.IsDigit(ch))
                {
                    return "Invalid number!";
                }
            }
            return $"Calling... {number}";

        }
    }
}
