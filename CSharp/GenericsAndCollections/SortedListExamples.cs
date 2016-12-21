using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.GenericsAndCollections
{
    public class SortedListExamples
    {
        public static void Example()
        {
            var sortedList = new SortedList();
            sortedList["Pizza"] = 15;
            sortedList.Add("Hot Dog", 2);
            sortedList.Add("Noodles", 6);
            sortedList.Add("Burger", 5);

            Console.WriteLine("Price of the Pizza is {0}", sortedList["Pizza"]);
            Console.WriteLine("\nList of food items:");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine("Price of {0} is {1}", item.Key, item.Value);
            }

            Console.WriteLine("\nList of food items:");
            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine("Price of {0} is {1}", sortedList.GetKey(i), sortedList.GetByIndex(i));
            }
        }
    }
}
