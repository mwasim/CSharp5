using System;

namespace CSharp.ReferenceTypes
{
    public class EscapeSequence
    {
        public static void DisplayOutput()
        {
            Console.WriteLine("\'Hello\'");
            Console.WriteLine("\"Hello\"");
            Console.WriteLine("\\Hello\\");
            Console.WriteLine("There is a null value between Hello\0World");
            Console.WriteLine("Alert signal \a");
            Console.WriteLine("Yes\b\b\bNo");
            Console.WriteLine("Form feed: Hello\fWorld");
            Console.WriteLine("Hello\nWorld");
            Console.WriteLine("Carriage Return Without New Line: Hello\rWorld");
            Console.WriteLine("Carriage Return With New Line: Hello\r\nWorld");
            Console.WriteLine("Hello \tWorld");
            Console.WriteLine("Vertial Tab: Hello \vWorld");
        }
    }
}
