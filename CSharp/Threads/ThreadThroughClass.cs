using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp.Threads
{
    public class ThreadThroughClass
    {
        public void ThreadCode()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("This is the child thread {0}", i);
                Thread.Sleep(i * 250);
            }
        }
    }
}
