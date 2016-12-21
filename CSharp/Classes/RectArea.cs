using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Classes
{
    public class RectArea
    {
        private int l, b;
        public RectArea(int x, int y)
        {
            l = x;
            b = y;
            Console.WriteLine("Constructor is called");
        }

        public int GetRect()
        {
            return l * b;
        }

        ~RectArea()
        {
            Console.WriteLine("Finalizer is called.");
        }

    }

    
}
