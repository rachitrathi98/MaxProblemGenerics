using System;
using System.Collections.Generic;
using System.Text;

namespace MaxNumberGenerics
{
    public class MaxNum<T> where T : IComparable
    {
        public static  T Max(T[] arr)
        {
              Array.Sort(arr);
            return arr[arr.Length-1];
        }
        

    }
}
