using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.GenericsAndCollections
{
    public class CGDemo
    {
        /// <summary>
        /// IEnumerable Example
        /// </summary>
        public static void IteratorBlockExample()
        {
            foreach (var item in IEnumerableExamples.IteratorBlock())
            {
                Console.WriteLine(item);
            }
        }

        public static void IEnumeratorExample()
        {
            string[] numbers = { "0", "1", "2", "3", "4"};

            IEnumerator enums = numbers.GetEnumerator();

            while (enums.MoveNext())
            {
                Console.WriteLine(enums.Current);
            }

            Console.WriteLine("\n\nResetting");
            enums.Reset();
            Console.WriteLine("\nRepeating Again.");
            while (enums.MoveNext())
            {
                Console.WriteLine(enums.Current);
            }
        }

        public static void StringEnumerableExample()
        {
            foreach (var item in IEnumerableExamples.GetStringEnumerable())
            {
                Console.WriteLine(item);
            }
        }

        public static void ArrayEnumeratorExample()
        {
            int[] arr = { 1, 2, 3, 4, 5};

            var singleDimArr = new SingleDim(arr);
            Console.WriteLine("SingleDim Array elements are:");
            foreach (var item in singleDimArr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nInteger array elements are:");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public static void HashTableExample()
        {
            HashtableExamples.Example();
        }

        public static void SortedListExample()
        {
            SortedListExamples.Example();
        }

        public static void BitArrayExample()
        {
            BitArrayExamples.Example();
        }

        public static void StackExample()
        {
            StackExamples.Example();
        }

        public static void QueueExample()
        {
            QueueExamples.Example();
        }


        public static void GenericSwapExample()
        {
            int x = 3, y = 5;
            Console.WriteLine("X = {0}, Y = {1}", x, y);
            GenericsExamples.GenericSwap<int>(ref x, ref y);
            Console.WriteLine("After swapping, X = {0}, Y = {1}", x, y);
        }

        public static void GenericListExample()
        {
            GenericsExamples.ListExample();
        }

        public static void GenericObjectListExample()
        {
            GenericsExamples.ListOfObjects();
        }

        public static void GenericQueueStackExample()
        {
            Console.WriteLine("STACK EXAMPLE");
            Console.WriteLine("-------------");
            GenericsExamples.StackExample();

            Console.WriteLine("\n\nQUEUE EXAMPLE");
            Console.WriteLine("-------------");
            GenericsExamples.QueueExample();
        }

        public static void GenericSortedSetExample()
        {
            GenericsExamples.SortedSetExample();
        }

        public static void GenericDictionaryExample()
        {
            GenericsExamples.DictionaryExample();
        }

        public static void GenericLinkedListExample()
        {
            GenericsExamples.LinkedListExample();
        }
    }
}
