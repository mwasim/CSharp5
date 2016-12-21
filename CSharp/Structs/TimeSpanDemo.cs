using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Structs
{
    public class TimeSpanDemo
    {
        public static void Example()
        {
            var today = DateTime.Today;
            var customDate1 = new DateTime(2016, 12, 01);

            Console.WriteLine("Today, Long Format: {0}, Short Format: {1}", today.ToLongDateString(), today.ToShortDateString());

            Console.WriteLine("Day in 2-digits: {0}, Month in string: {1}, Year in 2-digits: {2}",
                today.ToString("dd"), today.ToString("MMM"), today.ToString("yy"));

            Console.WriteLine("Weekday in 3-letter-format: {0}, Full Day: {1}", today.ToString("ddd"), today.ToString("dddd"));

            var elapsed = today.Subtract(customDate1);
            double daysDifference = elapsed.TotalDays;

            Console.WriteLine("The number of days between {0} and {1} are: {2}", today.ToString("d"), customDate1.ToString("d"), daysDifference);

            var workStarted = new DateTime(2016, 12, 02, 9,0,0);
            var workFinished = new DateTime(2016, 12, 02, 18, 30, 15);
            var timeTaken = workFinished - workStarted;

            Console.WriteLine("Total time taken to finish the work: {0} i.e. {1} day, {2} hours, {3} minutes, and {4} seconds",
                timeTaken, timeTaken.Days, timeTaken.Hours, timeTaken.Minutes, timeTaken.Seconds);

            var dateTimeSpan = today.Add(timeTaken);
            Console.WriteLine("Today's date {0} after adding the time taken {1} becomes {2}", today, timeTaken, dateTimeSpan);

            if (DateTime.IsLeapYear(today.Year))
            {
                Console.WriteLine("The current year is: {0}, and it's a leap year.", today.Year);
            }
            else
            {
                Console.WriteLine("The current year is: {0}, and it's not a leap year.", today.Year);
            }
        }
    }
}
