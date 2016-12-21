using System;

namespace CSharp.Misc
{
    enum Weekdays { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
    public class TheEnum
    {
        public static void DisplayOutput()
        {
            var w = Weekdays.Tuesday;

            Console.WriteLine("Weekday is {0}", w);
            Console.WriteLine("Position of {0} in the enumeration is {1}", w, (int)w);
        }
    }
}
