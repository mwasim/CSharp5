using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Structs
{
    public class DateTimeStructDemo
    {
        public static void Example()
        {
            var today = DateTime.Today;
            var customDate1 = new DateTime(2016, 12, 01);
            var date1 = customDate1;

            var dateStr = "12/5/2016 10:15:30 AM";
            var customDate2 = DateTime.Parse(dateStr);

            var customDate3 = new DateTime(1000000);

            var yesterday = DateTime.Today.AddDays(-1);
            var tomorrow = DateTime.Today.AddDays(1);

            Console.WriteLine("Today: {0}", today);
            Console.WriteLine("Custom Date 1: {0}", customDate1);
            Console.WriteLine("Copy of Custom Date: {0}", date1);
            Console.WriteLine("Date Created through a string: {0}", customDate2);
            Console.WriteLine("Date created based on ticks 1000000: {0}", customDate3);
            Console.WriteLine("Yesterday: {0}", yesterday);
            Console.WriteLine("Tomorrow: {0}", tomorrow);

            Console.WriteLine("Current Day: {0}, Month: {1}, Year: {2}", today.Day, today.Month, today.Year);
            Console.WriteLine("Day of the Week: {0}, Day of the Year: {1}", today.DayOfWeek, today.DayOfYear);
        }

        public static void DateTimeFormats()
        {
            var now = DateTime.Now;

            Console.WriteLine("Short Date: {0}", now.ToString("d"));
            Console.WriteLine("Long Date: {0}", now.ToString("D"));
            Console.WriteLine("Short Time: {0}", now.ToString("t"));
            Console.WriteLine("Long Time: {0}", now.ToString("T"));
            Console.WriteLine("Full Date (Short Time Pattern): {0}", now.ToString("f"));
            Console.WriteLine("Full Date (Long Time Pattern): {0}", now.ToString("F"));
            Console.WriteLine("General (Short date/time pattern): {0}", now.ToString("g"));
            Console.WriteLine("General (Short Date/Long time pattern): {0}", now.ToString("G"));
            Console.WriteLine("Month/day pattern: {0}", now.ToString("m"));
            Console.WriteLine("Month Year pattern: {0}", now.ToString("y"));
            Console.WriteLine("RFC1123 pattern: {0}", now.ToString("r"));
            Console.WriteLine("Sortable datetime pattern: {0}", now.ToString("s"));
            Console.WriteLine("Universal sortable datetime pattern: {0}", now.ToString("u"));

        }
    }
}
