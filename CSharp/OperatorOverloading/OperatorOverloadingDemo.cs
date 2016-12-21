using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.OperatorOverloading
{
    public class OperatorOverloadingDemo
    {
        public static void AddingProductsAndNumbers()
        {
            var p1 = new Product(5, 75.85M);
            var p2 = new Product(3, 95.50M);

            var p3 = p1 + p2;
            var p4 = p3 + 25;
            var p5 = 8 + p4;

            p1.Show();
            p2.Show();
            p3.Show();
            p4.Show();
            p5.Show();
        }

        public static void AddingComplexNumbers()
        {
            var c1 = new Complex(5, 12);
            var c2 = new Complex(16, 3);

            var c3 = c1 + c2;

            Console.WriteLine("Complex Number 1: {0}", c1.ToString());
            Console.WriteLine("Complex Number 2: {0}", c2.ToString());
            Console.WriteLine("Complex Number 1 added to Complex Number 2: {0}", c3.ToString());
        }

        public static void IncrementDecrementProduct()
        {
            var p1 = new Product(15, 25.75M);
            p1.Show();

            Console.WriteLine("After incrementing by 1");
            p1++;
            p1.Show();
            Console.WriteLine("After decrementing by 1");
            p1--;
            p1.Show();
        }

        public static void ProductTrueFalse()
        {
            var p = new Product(3, 95.50M);

            if (p)
            {
                Console.WriteLine("The following product's quantity is non-zero.");
                p.Show();
            }
            else
            {
                Console.WriteLine("The following product's quantity is zero.");
                p.Show();
            }

        }

        public static void ProductComparison()
        {
            var p = new Product(5, 25.50M);
            if (p == true)
            {
                Console.WriteLine("The following product's quantity is non-zero.");
                p.Show();
            }

            var p2 = new Product();
            if (!p2)
            {
                Console.WriteLine("The following product's quantity is zero.");
                p2.Show();
            }

            if (p > p2)
            {
                Console.WriteLine("First products quanity is more than the second one.");
                Console.WriteLine("First Product is:");
                p.Show();
                Console.WriteLine("Second Product is:");
                p2.Show();
            }

            var p3 = new Product(1, 75.25M);
            if (p3 < p)
            {
                Console.WriteLine("First products quanity is less than the second one.");
                Console.WriteLine("First Product is:");
                p3.Show();
                Console.WriteLine("Second Product is:");
                p.Show();
            }

            var p4 = p3;
            if(ReferenceEquals(p3, p4))
            {
                Console.WriteLine("Both of the products refer to the same product");
                p3.Show();
                p4.Show();
            }

            Console.WriteLine("\n\nChecking Products are equal or not.");
            if (p != p3)
            {
                Console.WriteLine("The Following products' quanity are not equal.");
                p.Show();
                p2.Show();
            }

            if(p3 == p4)
            {
                Console.WriteLine("\n\nQuanity of the both of the following products is equal.");
                p3.Show();
                p4.Show();
            }
        }

        public static void InchesFeetConversion()
        {
            int feet = 2;

            var inches = (Inches)feet;

            Console.WriteLine("Feet = {0}, Inches = {1}", feet, inches.Inch);

            var inches2 = new Inches(72);
            int feet2 = inches2;

            Console.WriteLine("Inches = {0}, Feet = {1}", inches2, feet2);
        }
    }
}
