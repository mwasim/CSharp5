using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class ArrayListDemo
    {
        public static void DisplayEnteredFruits()
        {
            Console.Write("How many fruits would you like to enter?");
            var n = int.Parse(Console.ReadLine());

            var list = new ArrayList();
            Console.Write("Please enter {0} fruit names,", n);
            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }

            Console.WriteLine("\nThe entered fruits are:");
            foreach (var item in list)
            {
                Console.Write("{0}\n", item);
            }

            Console.WriteLine("\nThe entered fruits are:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}\n", list[i]);
            }
        }

        public static void Functions1()
        {
            var list1 = new ArrayList();
            var list2 = new ArrayList();

            list1.Add("Apple");
            list1.Add("Orange");
            list1.Add("Mango");

            list2.Add("Ice cream");
            list2.Add("Sandwich");

            Console.WriteLine("The first list contains number of elements = {0}", list1.Count);
            Console.WriteLine("The second list contains number of elements = {0}", list2.Count);

            list1.AddRange(list2);
            Console.WriteLine("After adding list2 elements to the first, the first list contains elements '{0}' as below,", list1.Count);
            foreach (var item in list1)
            {
                Console.Write("{0}\n", item);

            }

            list2.Clear();
            Console.WriteLine("After clearing, the second list contains number of elements = {0}", list2.Count);

            list2.AddRange(list1.GetRange(3, 2));
            Console.WriteLine("After copying few elments from the first list, the second list contains elements '{0}' as below,", list2.Count);
            foreach (var item in list2)
            {
                Console.Write("{0}\n", item);
            }

            list1.RemoveAt(0);
            Console.WriteLine("After removing the first element, the first list contains elements '{0}' as below,", list1.Count);
            foreach (var item in list1)
            {
                Console.Write("{0}\n", item);
            }

            list1.RemoveRange(2,2);
            Console.WriteLine("After removing the last two elements, the first list contains elements '{0}' as below,", list1.Count);
            foreach (var item in list1)
            {
                Console.Write("{0}\n", item);
            }

            list1.Insert(0, "Apple");
            Console.WriteLine("After inserting an element at the top, the first list contains elements '{0}' as below,", list1.Count);
            foreach (var item in list1)
            {
                Console.Write("{0}\n", item);
            }

            var list3 = list1.GetRange(0, list1.Count);
            Console.WriteLine("Copying list1 to list 3, the 3rd list contains elements '{0}' as below,", list1.Count);
            foreach (var item in list3)
            {
                Console.Write("{0}\n", item);
            }
                      
        }

    }
}
