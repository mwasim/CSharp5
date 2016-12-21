using System;

namespace CSharp.Formats
{
    public class StringFormats
    {
        public static void DisplayOutput()
        {
            decimal a = 1234.75M;
            int b = 1234;

            Console.WriteLine("Currency format with precision, 2: {0,10:C2}", a);
            Console.WriteLine("Decimal format with precision, 8: {0,10:D8}", b);
            Console.WriteLine("Default scientific format: {0,10:E}, and scientific format with 4 places of decimal: {0,10:e4}", a, a);
            Console.WriteLine("Fixed point format with 3 number of decimal places: {0,10:F3}", a);
            Console.WriteLine("General Format: {0,10:G}", a);
            Console.WriteLine("Number Format: {0,10:N}", a);
            Console.WriteLine("Percent Format: {0,10:P}", a);
            Console.WriteLine("Hexadecimal format with precision, 6: {0,10:X6}", b);
        }
    }
}
