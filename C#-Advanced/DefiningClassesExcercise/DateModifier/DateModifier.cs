using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace DefiningClasses
{
   public class DateModifier
    {
        public string ModifyDate(string firstDate, string secondDate)
        {
            firstDate = firstDate.Replace(" ", ".");
            secondDate = secondDate.Replace(" ", ".");
            
            var parsedFirst = DateTime.Parse(firstDate);
            var parsedSecond = DateTime.Parse(secondDate);
            return Math.Abs((parsedFirst - parsedSecond).Days).ToString();
        }
    }
}
