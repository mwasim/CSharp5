using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Services
{
    public class ServicesExamples
    {
        public static void WCFCalculateServiceExample()
        {
            CalculateService.Service1Client client = new CalculateService.Service1Client();

            int num1 = 10, num2 = 20, num3 = 5;

            Console.WriteLine("Average of {0}, {1}, and {2} is: {3}", num1, num2, num3, client.GetAverage(num1, num2, num3));
        }
    }
}
