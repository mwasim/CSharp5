using System;

namespace CSharp.Misc
{
    public class CheckUncheck
    {
        public static void DisplayOutput()
        {
            int a = 2000000000;
            int b = 2000000000;

            //int c = 2000000000 + 2000000000; //Display compile time error - operation overflows

            int c = a + b;
            Console.WriteLine("Value of C = {0}", c);

            Console.WriteLine("Unchecked - preventing overflow checking. Value of C = {0}", unchecked(a + b));
            Console.WriteLine("Checked - Checking overflow at runtime. Value of C = {0}", checked(a + b));
        }
    }
}
