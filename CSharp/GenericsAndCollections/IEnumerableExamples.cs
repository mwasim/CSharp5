using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.GenericsAndCollections
{
    public class IEnumerableExamples
    {
        public static IEnumerable IteratorBlock()
        {
            for (int i = 0; i < 5; i++)
            {
                yield return i.ToString();
            }

            yield return "Numbers Over";
        }


        public static IEnumerable<string> GetStringEnumerable()
        {
            for (int i = 0; i < 5; i++)
            {
                yield return i.ToString();
            }

            yield return "Numbers are over.";
        }
    }
}
