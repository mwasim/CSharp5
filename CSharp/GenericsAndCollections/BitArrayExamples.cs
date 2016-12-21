using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.GenericsAndCollections
{
    public class BitArrayExamples
    {
        public static void Example()
        {
            var bitArray = new BitArray(5);

            bitArray[0] = false;
            bitArray[1] = true;
            bitArray[2] = true;
            bitArray[3] = false;
            bitArray[3] = false;

            Console.WriteLine("Boolean values in the bit array are:");
            for (int i = 0; i < bitArray.Count; i++)
            {
                Console.WriteLine("{0}", bitArray[i]);
            }

            Console.WriteLine("\nBoolean values in the bit array are:");
            IEnumerator ienum = bitArray.GetEnumerator();
            while (ienum.MoveNext())
                Console.WriteLine(ienum.Current);

            Console.WriteLine("\nOutput in the binary format:");
            for (int i = 0; i < bitArray.Count; i++)
            {
                Console.Write(bitArray[i] ? 1 : 0);
            }
        }
    }
}
