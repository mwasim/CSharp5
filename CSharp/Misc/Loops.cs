using System;

namespace CSharp.Misc
{
    public class Loops
    {
        public static void DisplayOutput()
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write("{0}\t", j);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}\t", j);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}\t", j);
                }
                Console.WriteLine();
            }
        }
    }
}
