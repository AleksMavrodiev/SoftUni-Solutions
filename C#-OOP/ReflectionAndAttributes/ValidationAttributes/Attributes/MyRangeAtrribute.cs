using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes.Attributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class MyRangeAtrribute : MyValidationAttribute
    {
        private readonly int minValue;
        private readonly int maxValue;

        public MyRangeAtrribute(int minValue, int maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        public override bool IsValid(object obj)
        {
            if (obj is int val)
            {
                return val >= minValue && val <= maxValue;
            }
            return false;
        }
    }
}
