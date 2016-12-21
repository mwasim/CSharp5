using System;

namespace CSharp.Arrays
{
    public class TwoDimArray
    {
        public static void DisplayOutput()
        {
            int[,] twoDimArr = new int[2, 4];

            Console.WriteLine("Enter elements of an array of order 2x4");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    twoDimArr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nThe elements in the two-dimensional array are,");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0}\t", twoDimArr[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
