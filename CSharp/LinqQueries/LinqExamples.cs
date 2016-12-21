using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp.LinqQueries
{
    public class LinqExamples
    {
        public static void ImplicitlyTypedLocalVariables()
        {
            var n = 10;
            var msg = "Hello World!";
            var price = 15.75;
            var arrayInt = new[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("n is: {0}", n.GetType().Name);
            Console.WriteLine("msg is: {0}", msg.GetType().Name);
            Console.WriteLine("price is: {0}", price.GetType().Name);
            Console.WriteLine("arrayInt is: {0}", arrayInt.GetType().Name);
        }

        public static void DisplayEventNumbers()
        {
            var list = new List<int> { 8, 5, 1, 0, 2, 10, 6, 23, 18, 4 };
            var evenNumberList = list.FindAll(i => i % 2 == 0);

            Console.WriteLine("All numbers are: ");
            foreach (var item in list)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine("Even numbers are: ");
            foreach (var n in evenNumberList)
            {
                Console.Write("{0} ", n);
            }
        }

        public static void ExtensionMethodExample()
        {
            Console.WriteLine("Enter an email to validate or 'q' to quit.\n\n");

            var input = string.Empty;
            do
            {
                input = Console.ReadLine();
                if (input != "q")
                {
                    var isValidEmail = input.IsValidEmail();

                    Console.WriteLine("{0} is valid email address? {1}", input, isValidEmail ? "Yes" : "No");
                }

            } while (input != "q");
        }

        public static void LinqFruitsFilterExample1()
        {
            string[] fruits = { "Apple", "Mango", "Grapes", "Pineapple", "Banana" };

            var selectedFruits = from f in fruits
                                 where f.Length >= 6
                                 orderby f
                                 select f;

            Console.WriteLine("All fruits are below: ");
            foreach (var item in fruits)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine("\n\nFiltered (fruit names length equal or more to 6) fruits are: ");
            foreach (var item in selectedFruits)
            {
                Console.Write("{0} ", item);
            }

        }

        public static void AnonymousTypesExample()
        {
            var product = new { Code = 101, Name = "Laptop", Price = 310.55 };
            Console.WriteLine("Anonymous Product is:");
            Console.WriteLine("Code = {0}, Name = {1}, Price = ${2}\n\n", product.Code, product.Name, product.Price);
        }

        public static void LinqToXmlExample()
        {
            var products = new List<Product> {
                new Product { Code = 101, Name = "Laptop", Price = 299.99M },
                new Product { Code = 102, Name = "Mobile", Price = 249.99M },
                new Product { Code = 103, Name = "Tablet", Price = 275.99M }
               };

            Console.WriteLine("Products are below: ");
            foreach (var item in products)
            {
                Console.WriteLine("Code: {0}, Name: {1}, Price: {2} ", item.Code, item.Name, item.Price);
            }


            Console.WriteLine("\n\nXML representation is below: ");

            var xml = new XElement("Products",
                from p in products
                where p.Price >= 250
                select new XElement("Product",
                    new XAttribute("Code", p.Code),
                    new XElement("Name", p.Name),
                    new XElement("Price", p.Price)
                    )
                );

            Console.WriteLine(xml);
        }



        private class Product
        {
            public int Code { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
        }
    }


}
