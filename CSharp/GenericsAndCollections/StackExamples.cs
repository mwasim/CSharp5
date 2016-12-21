using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.GenericsAndCollections
{
    public class StackExamples
    {
        public static void Example()
        {
            var stack = new Stack();

            stack.Push("John");
            stack.Push("Carroline");
            stack.Push("Kelly");

            Console.WriteLine("Element popped: {0}", stack.Pop());
            Console.WriteLine("Element at the top: {0}", stack.Peek());
            Console.WriteLine("Element popped: {0}", stack.Pop());
            Console.WriteLine("Elements Count: {0}", stack.Count);
        }
    }
}
