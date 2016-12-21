using System;

namespace CSharp.Arrays
{
    public class OneDimArray
    {
        public static void DisplayOutput()
        {
            int[] arr = new int[10];

            Console.WriteLine("Please enter 10 numbers:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nThe numbers entered in the array are");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }

        public static void ArrayInitDemo()
        {
            int[] arr = { 1, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("\nThe numbers entered in the array are");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void ForeachAndSort()
        {
            int[] arr = { 10, 3, 2, 9, 8, 6, 7, 4, 5, 1 };

            Console.WriteLine("Contents of the array are,");
            foreach (var n in arr)
            {
                Console.Write("{0}, ", n);
            }

            Array.Sort(arr); //sorting
            Console.WriteLine("\nAfter Sorting, the contents of the array are,");
            foreach (var n in arr)
            {
                Console.Write("{0}, ", n);
            }
        }
    }
}
