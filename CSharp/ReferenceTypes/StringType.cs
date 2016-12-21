using System;

namespace CSharp.ReferenceTypes
{
    public class StringType
    {
        public static void DisplayOutput()
        {
            string a = "Hello";
            string b = @"Hello";
            string c = "\\Hello\\";
            string d = @"\Hello\";
            string e = "Hello \t World";
            string f = @"Hello \t World";
            string g = "\"Hello\"";
            string h = @"""Hello""";
            string i = "Hello\nWorld\nThanks";
            string j = @"Hello
World
Thanks";


            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
            Console.WriteLine(j);
        }
    }
}