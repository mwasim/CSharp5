using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Classes
{
    public class Rectangle
    {
        private int l, b, a;
        public void SetRectangle(int x, int y)
        {
            l = x;
            b = y;
        }

        public int RectangleArea()
        {
            a = l * b;
            return a;
        }
    }

    public class Triangle : Rectangle
    {
        private int b, h;
        private float a;

        public void SetTriangle(int x, int y)
        {
            b = x;
            h = y;
        }

        public float GetTriangleArea()
        {
            a = (float)1 / 2 * b * h;
            return a;
        }
    }

    public class SingleInheritance
    {
    }
}
