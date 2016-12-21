using System;

namespace CSharp.Misc
{
    public class Bitwise
    {
        public static void DisplayOutput()
        {
            int a, b, c, d, e, f, g;
            a = 10;
            b = 7;

            c = a & b;
            d = a ^ b;
            e = a | b;

            Console.WriteLine("{0} & {1} = {2}", a, b, c);
            Console.WriteLine("{0} ^ {1} = {2}", a, b, d);
            Console.WriteLine("{0} | {1} = {2}", a, b, e);

            f = a << 2; //left shifting => Multiplying 10 (a = 10) by 4
            Console.WriteLine("{0} << 2 = {1}", a, f);

            g = a >> 1; //Right shifting => Dividing 10 (a = 10) by 2
            Console.WriteLine("{0} >> 1 = {1}", a, g);

            Console.WriteLine("Bitwise negation of {0} is {1}", a, ~a);
        }
    }
}
