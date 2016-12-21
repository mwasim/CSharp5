using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.GenericsAndCollections
{
    public class HashtableExamples
    {
        public static void Example()
        {
            var htable = new Hashtable();

            htable["Pizza"] = 15;
            htable["Hot Dog"] = 2;
            htable.Add("Noodles", 6);
            htable.Add("Burger", 5);

            Console.WriteLine("Pizza Price = {0}", htable["Pizza"]);

            //hashtable keys
            var htKeys = htable.Keys;
            Console.WriteLine("\nFood Items are:");
            foreach (var key in htKeys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("\nPrices of different foods are:");
            foreach (DictionaryEntry item in htable)
            {
                Console.WriteLine("Price of {0} is {1}", item.Key, item.Value);
            }

            htable.Remove("Hot Dog");
            Console.WriteLine("\nPrices of different foods are:");
            foreach (DictionaryEntry item in htable)
            {
                Console.WriteLine("Price of {0} is {1}", item.Key, item.Value);
            }
        }
    }
}
