﻿using System;
using System.Collections.Generic;
using System.Text;
using ValidationAttributes.Attributes;

namespace ValidationAttributes
{
    public class Person
    {
        private const int AgeMinValue = 12;
        private const int AgeMaxValue = 90;

        public Person(string fullName, int age)
        {
            this.FullName = fullName;
            this.Age = age;
        }

        [MyRequired]
        public string FullName { get; set; }

        [MyRangeAtrribute(AgeMinValue, AgeMaxValue)]
        public int Age { get; set; }
    }
}
