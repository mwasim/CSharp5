using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.GenericsAndCollections
{
    public class SingleDim : IEnumerable
    {
        private int[] array;
        public SingleDim(int[] arr)
        {
            array = arr;
        }
        public IEnumerator GetEnumerator()
        {
            return new ArrayEnumerator(this);
        }

        private class ArrayEnumerator : IEnumerator
        {
            private int loc = -1;
            private SingleDim sa;
            public ArrayEnumerator(SingleDim a)
            {
                sa = a;
            }

            public object Current
            {
                get
                {
                    return sa.array[loc];
                }
            }

            public bool MoveNext()
            {
                if (loc < sa.array.Length - 1)
                {
                    loc++;
                    return true;
                }

                return false;
            }

            public void Reset()
            {
                loc = -1;
            }
        }
    }
}
