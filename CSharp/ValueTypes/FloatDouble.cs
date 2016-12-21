using System;

namespace CSharp.ValueTypes
{
    public class FloatDouble
    { 
        public static void DisplayOutput()
        {
            float a;
            double b;

            a = 3.0F / 7.0F;
            b = 3.0 / 7.0;

            Console.WriteLine("Floating Point Value is = {0}", a);
            Console.WriteLine("Double Value is = {0}", b);
        }
    }
}
