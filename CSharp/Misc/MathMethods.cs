using System;

namespace CSharp.Misc
{
    public class MathMethods
    {
        public static void DisplayOutput()
        {
            double a = -10.15;
            double b = Math.Abs(a);

            double c = 90;
            double d = Math.Cos(c);

            double e = Math.Pow(2, 3);

            double f = 1.2;
            double g = Math.Exp(f);

            double h = 12.3456789;
            double i = Math.Floor(h);

            double j = -12.3456789;
            double k = Math.Floor(j);

            double l = Math.Ceiling(h);
            double m = Math.Ceiling(j);

            double n = Math.Truncate(h);

            double o = Math.Sqrt(2);

            Console.WriteLine("Math.Abs({0}) = {1}", a, b);
            Console.WriteLine("Math.Cos({0}) = {1}", c, d);
            Console.WriteLine("Math.Pow(2,3) = {0}", e);
            Console.WriteLine("Math.Floor({0}) = {1}", h, i);
            Console.WriteLine("Math.Floor({0}) = {1}", j, k);
            Console.WriteLine("Math.Ceiling({0}) = {1}", h, l);
            Console.WriteLine("Math.Ceiling({0}) = {1}", j, m);
            Console.WriteLine("Math.Truncate({0}) = {1}", h, n);
            Console.WriteLine("Math.Sqrt(2) = {0}", o);
            Console.WriteLine("Value of PI = {0}", Math.PI);

            Console.WriteLine("Natural log of 100 is {0}", Math.Log10(100));
        }
    }
}
