using System;
using System.Collections.Generic;
using System.Text;

namespace Summator
{
    public class Summator
    {
        public static int Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}
