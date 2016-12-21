using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySharedAssembly;

namespace CSharp.Assemblies
{
    public class AssemblyExamples
    {
        public static void SharedAssemblyUsageExample()
        {
            var num1 = 5;
            var num2 = 6;
            var sum = Calculator.AddNumbers(num1, num2);
            Console.WriteLine("Sum of {0} and {1} is {2}", num1, num2, sum);
        }
    }
}
