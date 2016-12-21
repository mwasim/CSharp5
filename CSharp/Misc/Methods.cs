using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Misc
{
    public class Methods
    {
        public static void VariableNumParams(params string[] names)
        {
            Console.WriteLine("Passed names are:");
            foreach (var item in names)
            {
                Console.Write("{0}\n", item);
            }
        }
    }
}
