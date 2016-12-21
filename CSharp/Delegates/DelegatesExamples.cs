using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Delegates
{
    public delegate int CalculateArea(int length, int breadth);
    public delegate int AddMultNumbers(int a, int b);

    public delegate RectangleArea CoverianceDelegate();
    public delegate void ContraVerianceDelegate(TriangleArea obj);

    public delegate T AddMultNumbers<T>(T a, T b);
    public delegate T2 AddMultNumbers<T1, T2>(T1 a, T1 b);

    public class DelegatesExamples
    {
        public static int RectangleArea(int length, int breadth)
        {
            return length * breadth;
        }

        public static int AddNumbers(int x, int y)
        {
            var sum = x + y;
            Console.WriteLine("Addition of {0} and {1} is: {2}", x, y, sum);
            return sum;
        }

        public static float AddNumbers(float x, float y)
        {
            var sum = x + y;
            Console.WriteLine("Addition of {0} and {1} is: {2}", x, y, sum);
            return sum;
        }

        public static float CaculateTriangleArea(int x, int y)
        {
            var a = (float)1 / 2 * (x * y);
            Console.WriteLine("Triangle Area of {0} and {1} is: {2}", x, y, a);
            return a;
        }

        public static int MultiplyNumbers(int x, int y)
        {
            var prod = x * y;
            Console.WriteLine("Product of {0} and {1} is: {2}", x, y, prod);
            return prod;
        }

        public static float MultiplyNumbers(float x, float y)
        {
            var prod = x * y;
            Console.WriteLine("Product of {0} and {1} is: {2}", x, y, prod);
            return prod;
        }

        public static void PassingRectArea(RectangleArea obj)
        {
            Console.WriteLine("RectangleArea object is passed to this method.");
        }

        public static void PassingTriangleArea(TriangleArea obj)
        {
            Console.WriteLine("TriangleArea object is passed to this method.");
        }
    }

    public class Shape
    {
        //public int Length { get; set; }
        //public int Breadth { get; set; }
        //public Shape(int l, int b)
        //{
        //    Length = l;
        //    Breadth = b;
        //}

        public int Area(int x, int y)
        {
            return x * y;
        }
    }

    public class RectangleArea
    {
        public RectangleArea GetRectArea()
        {
            Console.WriteLine("Returning the Rectangle Area object.");
            return this;
        }
    }

    public class TriangleArea : RectangleArea
    {
        public TriangleArea GetTrgArea()
        {
            Console.WriteLine("Returning the Triangle Area object.");
            return this;
        }
    }

    public delegate void ProductDelegate();
    public class Product
    {

        public event ProductDelegate ProductEvent;
        public int Quantity { get; set; }

        public Product(int quantity)
        {
            Quantity = quantity;
        }

        public void RaiseEvent()
        {
            ProductEvent();
        }

        public void Display()
        {
            Console.WriteLine("Product Quantity: {0}", Quantity);
        }
    }


    public delegate void CalculateRectangleArea();
    public class Rect
    {
        int l, b;
        private CalculateRectangleArea RectEvent;
        public Rect(int x, int y)
        {
            l = x;
            b = y;
        }

        public void DisplayArea()
        {
            Console.WriteLine("Rectangle Area: {0}", l * b);
        }

        public void RaiseEvent()
        {
            RectEvent();
        }

        public event CalculateRectangleArea CalculateRectAreaEvent
        {
            add
            {
                Console.WriteLine("Attaching delegate {0} to the RectEvent.", value);
                RectEvent += value;
            }
            remove
            {
                Console.WriteLine("Removing delegate {0} from the RectEvent.", value);
                RectEvent -= value;
            }

        }
    }
}
