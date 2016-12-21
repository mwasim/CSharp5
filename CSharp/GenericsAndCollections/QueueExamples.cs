using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.GenericsAndCollections
{
    public class QueueExamples
    {
        public static void Example()
        {
            var queue = new Queue();

            queue.Enqueue("John");
            queue.Enqueue("Carroline");
            queue.Enqueue("Kelly");

            Console.WriteLine("Element Dequeued from the beginning: {0}", queue.Dequeue());
            Console.WriteLine("First Element: {0}", queue.Peek());
            Console.WriteLine("Element Dequeued from the beginning: {0}", queue.Dequeue());
            Console.WriteLine("Elements Count: {0}", queue.Count);
        }
    }
}
