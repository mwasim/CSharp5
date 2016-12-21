using System;

namespace CSharp.Misc
{
    public class RectAreaInput
    {
        public static void DisplayOutput()
        {
            int l, b, a;

            Console.Write("Please enter length: ");
            l = int.Parse(Console.ReadLine());

            Console.Write("Please enter breadth: ");
            b = int.Parse(Console.ReadLine());

            a = l * b;
            Console.WriteLine("Area of the rectangle is {0}", a);
        }
    }
}
