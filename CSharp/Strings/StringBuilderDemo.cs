using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Strings
{
    public class StringBuilderDemo
    {
        public static void AppendLineDemo()
        {
            Console.Write("How many fruits would you like to enter?");
            var n = int.Parse(Console.ReadLine());

            Console.Write("Pleae enter {0} name of fruits: ", n);
            var sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.AppendLine(Console.ReadLine());
            }

            Console.WriteLine("You have entered the following fruits:");
            Console.WriteLine(sb);
        }

        public static void Functions2()
        {
            var sb = new StringBuilder("it is hot today");
            Console.WriteLine("The original string is '{0}'", sb);

            sb.Replace("is", "was");
            Console.WriteLine("The modified string is '{0}'", sb);

            sb[0] = 'A';
            Console.WriteLine("After replacing the first character '{0}'", sb);

            sb.Remove(7, 3);
            Console.WriteLine("After removing a word: {0}", sb);

            var str = sb.ToString();
            Console.WriteLine("StringBuilder converted to a string '{0}'", str);
        }

        public static void Functions3()
        {
            var sb = new StringBuilder();
            int n1 = 10, n2 = 20;

            sb.AppendFormat("Value1: {0}, Value2: {1}, Addition is {2}", n1, n2, n1 + n2);
            Console.WriteLine("The original string builder is: '{0}'", sb);

            sb.Insert(24, "and ");
            Console.WriteLine("The string builder after inserting a word is: '{0}'", sb);

            sb.Append(" units");
            Console.WriteLine("The string builder after appending a word is: '{0}'", sb);
        }
    }
}
