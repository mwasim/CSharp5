using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp.Threads
{
    public class ThreadsExamples
    {
        public static void MainThreadExample()
        {
            var currentThread = Thread.CurrentThread;
            currentThread.Name = "Main Thread";

            Console.WriteLine("The current thread is {0}", currentThread.Name);
        }

        /// <summary>
        /// Step-1: Create System.Threading.Thread object
        /// Step-2: Create Thread's callback function(void as both parameter and return type) by instantiating the ThreadStart delegate
        /// Step-3: Start the thread
        /// </summary>
        public static void ChildThreadExample()
        {
            ThreadStart delegObj = new ThreadStart(ChildThread);
            var threadObj = new Thread(delegObj);
            Console.WriteLine("This is the main thread.");
            threadObj.Start();
        }


        public static void ChildThreadExample2()
        {
            ThreadStart delegObj = new ThreadStart(ChildThread1);
            var threadObj = new Thread(delegObj);
            Console.WriteLine("This is the main thread.");
            threadObj.Start();
        }

        public static void ChildThreadExample3()
        {
            ThreadStart delegObj = new ThreadStart(ChildThread1);
            var threadObj = new Thread(delegObj);
            threadObj.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("This is the main thread {0}.", i);
                Thread.Sleep(i * 250);
            }
        }

        public static void ThreadThroughClassExample()
        {
            var myThread = new ThreadThroughClass();
            ThreadStart delegObj = new ThreadStart(myThread.ThreadCode);

            var threadObj = new Thread(delegObj);
            Console.WriteLine("This is the main thread.");
            threadObj.Start();
        }

        private static Thread childThread;
        public static void ThreadStatesExample()
        {
            var delegObj = new ThreadStart(ChildThreadStates);
            Console.WriteLine("In Main: Creating the child thread.");
            childThread = new Thread(delegObj);
            childThread.Start();
            Thread.Sleep(3000);
            Console.WriteLine("Aborting the child thread.");
            childThread.Abort();
        }

        private static void ChildThreadStates()
        {
            try
            {
                Console.WriteLine("Child thread starts");
                Console.WriteLine("Child thread paused for 2 seconds");
                Thread.Sleep(2000);
                Console.WriteLine("Child thread resumes");
                Console.WriteLine("Child thread state: {0}", childThread.ThreadState);
                Thread.Sleep(1000);
                Console.WriteLine("Child thread completed.");
            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine("Child thread abort exception - {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("finally block.");
            }
        }

        private static void ChildThread()
        {
            Console.WriteLine("This is the child thread");
        }

        private static void ChildThread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("This is the child thread {0}", i);
                Thread.Sleep(i * 200);
            }
        }

        public static void ThreadPropertiesExample()
        {
            var mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";

            Console.WriteLine("Information of current thread.");
            Console.WriteLine("Thread Name: {0}", mainThread.Name);
            Console.WriteLine("Thread Status: {0}, State: {1}", mainThread.IsAlive, mainThread.ThreadState);
            Console.WriteLine("Priority: {0}", mainThread.Priority);
            Console.WriteLine("Context ID: {0}", Thread.CurrentContext.ContextID);
            Console.WriteLine("Managed Thread ID: {0}", mainThread.ManagedThreadId);
            Console.WriteLine("Current Application Domain: {0}", Thread.GetDomain().FriendlyName);
            Console.WriteLine("ApartmentState: {0}, {1}", mainThread.ApartmentState, mainThread.GetApartmentState());
            Console.WriteLine("CurrentCulture: {0}", mainThread.CurrentCulture);
            Console.WriteLine("CurrentUICulture: {0}", mainThread.CurrentUICulture);
            Console.WriteLine("ExecutionContext: {0}", mainThread.ExecutionContext);
            Console.WriteLine("IsBackground: {0}", mainThread.IsBackground);
            Console.WriteLine("IsThreadPoolThread: {0}", mainThread.IsThreadPoolThread);
        }

        private static int n = 10;
        static object resourceLock = new object();
        public static void MultipleThreadsExample()
        {
            Console.WriteLine("Starting Main Thread.");
            var delegObj = new ThreadStart(MultiThreadCode);
            var childThread1 = new Thread(delegObj);
            childThread1.Name = "ChildThread1";
            var childThread2 = new Thread(delegObj);
            childThread2.Name = "ChildThread2";
            childThread1.Start();
            childThread2.Start();

            Console.WriteLine("Value of n is {0}", n);
        }

        public static void MultipleThreadsExample2()
        {
            Console.WriteLine("Starting Main Thread.");
            var delegObj = new ThreadStart(MultiThreadCode);
            var childThread1 = new Thread(delegObj);
            childThread1.Name = "ChildThread1";
            var childThread2 = new Thread(delegObj);
            childThread2.Name = "ChildThread2";
            childThread1.Start();
            childThread2.Start();

            childThread1.Join();
            childThread2.Join();
            Console.WriteLine("Value of n is {0}", n);
        }

        public static void MultipleThreadsWithMonitorLock()
        {
            Console.WriteLine("Starting Main Thread.");
            var delegObj = new ThreadStart(MultiThreadMonitorLockCode);
            var childThread1 = new Thread(delegObj);
            childThread1.Name = "ChildThread1";
            var childThread2 = new Thread(delegObj);
            childThread2.Name = "ChildThread2";
            childThread1.Start();
            childThread2.Start();

            childThread1.Join();
            childThread2.Join();
            Console.WriteLine("Value of n is {0}", n);
        }

        public static void MultipleThreadsUsingLockStatement()
        {
            Console.WriteLine("Starting Main Thread.");
            var delegObj = new ThreadStart(MultiThreadLockStatementCode);
            var childThread1 = new Thread(delegObj);
            childThread1.Name = "ChildThread1";
            var childThread2 = new Thread(delegObj);
            childThread2.Name = "ChildThread2";
            childThread1.Start();
            childThread2.Start();

            childThread1.Join();
            childThread2.Join();
            Console.WriteLine("Value of n is {0}", n);
        }

        private static void MultiThreadCode()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " running.");
            n++;
        }

        private static void MultiThreadMonitorLockCode()
        {
            Monitor.Enter(resourceLock);
            try
            {
                Console.WriteLine(Thread.CurrentThread.Name + " running.");
                n++;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Monitor.Exit(resourceLock);
            }
        }

        private static void MultiThreadLockStatementCode()
        {
            lock (resourceLock)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " running.");
                n++;
            }            
        }

        private static Thread childThread2;
        public static void MultiThreadInterruptExample()
        {
            Console.WriteLine("Starting Main Thread.");
            var delegObj = new ThreadStart(MultiThreadInterruptCodeBlock1);
            var delegObj2 = new ThreadStart(MultiThreadInterruptCodeBlock2);
            childThread = new Thread(delegObj);
            childThread.Name = "ChildThread1";
            childThread2 = new Thread(delegObj2);
            childThread2.Name = "ChildThread2";
            childThread.Start();
            childThread2.Start();

            childThread.Join();
            childThread2.Join();
            Console.WriteLine("Exiting the main thread.");
            //Console.WriteLine("Value of n is {0}", n);
        }

        private static void MultiThreadInterruptCodeBlock1()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " running.");
            try
            {
                Console.WriteLine(Thread.CurrentThread.Name + " going to sleep.");
                Thread.Sleep(20);
            }
            catch (ThreadInterruptedException ex)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " interrupted - {0}", ex.Message);
            }
            Console.WriteLine("Exiting " + Thread.CurrentThread.Name);
        }

        private static void MultiThreadInterruptCodeBlock2()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " state: {0}", childThread.ThreadState);            
            Console.WriteLine("Interrupting " + childThread.Name);
            childThread.Interrupt();
        }
    }
}
