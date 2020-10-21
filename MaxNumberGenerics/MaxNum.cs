using System;
using System.Collections.Generic;
using System.Text;

namespace MaxNumberGenerics
{
    public class MaxNum<T> where T : IComparable
    {
        public static T maximum;

        public static void Max(T[] arr)
        {
              Array.Sort(arr);
            maximum= arr[arr.Length-1];
            PrintMax(maximum);
        }
        public static void PrintMax(T max)
        {
            Console.WriteLine("Max Value for " + typeof(T) + " is: " + max);
        }

    }
}
