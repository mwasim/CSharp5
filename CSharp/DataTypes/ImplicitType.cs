using System;

namespace CSharp.DataTypes
{
    public class ImplicitType
    {
        public static void DisplayOutput()
        {
            //Area of the circle = pi * r squared
            var pi = 3.1416; //implicitly defined as double type
            var radius = 5; //implicitly defined as int

            var area = pi * radius * radius;

            Console.WriteLine("Are of the circle is {0}", area);
        }
    }
}
