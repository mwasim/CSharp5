using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Operators
{
    public class TheIsOperator
    {
        public static void DisplayOutput()
        {
            int a = 10;
            object b = a;

            if (b is int)
            {
                var c = (int)b;
                Console.WriteLine("C = {0}", c);
            }
        }
    }
}
