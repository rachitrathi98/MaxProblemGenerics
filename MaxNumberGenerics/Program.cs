using System;

namespace MaxNumberGenerics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics Code!");
            Console.WriteLine();
            int[] arr1 = { 10, 20, 30, 40, 50 };
            int max1 = MaxNum<int>.Max(arr1);
            Console.WriteLine("Maximum Value for Int is: " + max1);

            Console.WriteLine();
            double[] arr2 = { 10.5, 20.5, 30.5, 40.5, 50.5 };
            double max2 = MaxNum<double>.Max(arr2);
            Console.WriteLine("Maximum Value for Float is: " + max2);

            Console.WriteLine();
            string[] arr3 = { "My", "name", "is", "Rachit", "Rathi" };
            string max3 = MaxNum<string>.Max(arr3);
            Console.WriteLine("Maximum Value for String is: " + max3);
        }
    }
}
