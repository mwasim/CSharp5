using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ErrorsAndExceptions
{
    public class ExceptionExamples
    {
        public static void DivideByZeroExample()
        {
            try
            {
                var x = 150;
                var y = 0;

                var z = x / y;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void MultipleTryBlocks()
        {
            try
            {
                var x = 150;
                var y = 0;

                var z = x / y;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                var arr = new int[] { 1, 2, 3 };
                Console.WriteLine(arr[3]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally block after raising index out of range exception.");
            }

            try
            {
                var value = Convert.ToInt32("John");
                Console.WriteLine(value);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void MultipleCatchBlocks()
        {
            try
            {
                var x = 150;
                var y = 0;

                var z = x / y;

                var arr = new int[] { 1, 2, 3 };
                Console.WriteLine(arr[3]);

                var value = Convert.ToInt32("John");
                Console.WriteLine(value);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally block.");
            }
        }

        /// <summary>
        /// Exception class is the base class so it can be used to catch all types of exceptions
        /// </summary>
        public static void CatchAllExceptions()
        {
            try
            {
                var x = 150;
                var y = 0;

                var z = x / y;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                var arr = new int[] { 1, 2, 3 };
                Console.WriteLine(arr[3]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally block after raising index out of range exception.");
            }

            try
            {
                var value = Convert.ToInt32("John");
                Console.WriteLine(value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void ThrowingAnException()
        {
            try
            {
                var x = 110;
                var y = 15;
                var z = x / y;

                Console.WriteLine("{0}/{1} = {2}", x, y, z);
                throw new DivideByZeroException();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void ThrowingAndExceptionExample2()
        {
            try
            {
                try
                {
                    var x = 150;
                    var y = 0;

                    var z = x / y;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    throw new IndexOutOfRangeException();
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                throw new FormatException("Format Exception Thrown Manually.");
            }
        }

        public static void InnerExceptionExample()
        {
            try
            {
                ThrowingAndExceptionExample2();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }
        }

        public static void CustomExceptionExample()
        {
            try
            {
                throw new CustomException("Hello!");
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Custom exception is caught - {0}", ex.ToString());
            }
        }

        public static void CheckedAndUncheckedOperatorExample()
        {
            var a = int.MaxValue;
            var b = byte.MaxValue;

            Console.WriteLine("Using checked operator:");
            Console.WriteLine("-----------------------");
            try
            {
                Console.WriteLine("Int32.Max: {0}", a);
                Console.WriteLine("Byte.Max: {0}", b);

                checked
                {
                    a++;
                    b++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught - {0}", ex.ToString());
            }

            Console.WriteLine("\n\nNow, the values are");
            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);

            Console.WriteLine("\n\nUsing unchecked operator:");
            Console.WriteLine("-----------------------");
            try
            {
                unchecked
                {
                    a++;
                    b++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nAfter incrementing in unchecked block, Now, the values are");
            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);
        }
    }

    public class CustomException : Exception
    {
        public CustomException()
        {
            Console.WriteLine("This is a custom exception.");
        }

        public CustomException(string message) : base(message)
        {

        }
    }
}
