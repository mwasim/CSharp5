using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Operators
{
    public class TheAsOperator
    {
        public static void DisplayOutput()
        {
            //as operator performs explicit type conversion
            int? a = 10;
            object b = a;

            int? c = b as int?;

            Console.WriteLine("Using 'as' operator, C = {0}", c);

            string str = b as string;

            Console.WriteLine("Using 'as' operator, str = {0}", str);
        }
    }
}
