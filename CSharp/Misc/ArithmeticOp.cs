using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Misc
{
    public class ArithmeticOp
    {
        public static void DisplayOutput()
        {
            int a = 5;
            int b = 3;
            int add = a + b;
            int mult = a * b;
            int div = a / b;
            int sub = a - b;

            int rem = a % b;
            double remdr = 5.123 % 3.123;

            int c = +a; //value of the variable will be assigned to the variable c
            int d = -a; //the variable will be multiplied by -1 and then assigned to the variable c

            Console.WriteLine("{0} + {1} = {2}", a, b, add);
            Console.WriteLine("{0} - {1} = {2}", a, b, sub);
            Console.WriteLine("{0} x {1} = {2}", a, b, mult);
            Console.WriteLine("{0} / {1} = {2}", a, b, div);
            Console.WriteLine("{0} % {1} = {2}", a, b, rem);
            Console.WriteLine("5.123 % 3.123 = {0}", remdr);
            Console.WriteLine("Sign Operators: {0}, and {1}", c, d);


        }
    }
}
