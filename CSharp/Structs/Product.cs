using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Structs
{
    public struct Product
    {
        public string code;
        public string productName;
        public decimal price;

        public Product(string c, string n, decimal p)
        {
            this.code = c;
            productName = n;
            price = p;
        }

        public void Show()
        {
            Console.WriteLine("Information of the product:");
            Console.WriteLine("Code = {0}\nName = {1}\nPrice = {2}", Code, Name, Price);
        }

        public string Code { get { return code; } set { code = value; } }
        public string Name { get { return productName; } set { productName = value; } }
        public decimal Price { get { return price; } set { price = value; } }

    }

    public struct Product2
    {
        private string code;
        private string productName;
        private decimal price;

        public Product2(string c, string n, decimal p)
        {
            this.code = c;
            productName = n;
            price = p;
        }

        public void Show()
        {
            Console.WriteLine("Information of the product:");
            Console.WriteLine("Code = {0}\nName = {1}\nPrice = {2}", Code, Name, Price);
        }

        public string Code { get { return code; } set { code = value; } }
        public string Name { get { return productName; } set { productName = value; } }
        public decimal Price { get { return price; } set { price = value; } }

    }

    public struct ProductWithArray {
        public string Code { get; set; }
        public string[] ProductInfo { get; set; }

        public void Show()
        {
            Console.WriteLine("Product information:");
            Console.Write("Code = {0}\n", Code);
            foreach (var s in ProductInfo)
            {
                Console.Write("{0}\n",s);
            }
        }
    }

    public struct ProductWithSpec {

        public ProductWithSpec(string c, string n, decimal p)
        {
            Code = c;
            Name = n;
            Price = p;
        }

        public void Show()
        {
            Console.WriteLine("Product Information:");
            Console.Write("Code: {0}\nName: {1}\nPrice: {2}", Code, Name, Price);            
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public struct Specification {

            public Specification(string c, string w, string s)
            {
                Color = c;
                Weight = w;
                Size = s;
            }

            public void Show()
            {
                Console.WriteLine("\n\nProduct Specifications:");
                Console.Write("Color: {0}\nWeight: {1}\nSize: {2}", Color, Weight, Size);
            }
            public string Color { get; set; }
            public string Weight { get; set; }
            public string Size { get; set; }
        }
    }

    public class StructDemo
    {
        public static void ProductExample()
        {
            Product p1 = new Product("C101", "Camera", 15.75M);
            Product p2, p3;
            Console.WriteLine("Information for the first product:");
            Console.WriteLine("Code = {0}\nName = {1}\nPrice = {2}", p1.code, p1.productName, p1.price);

            p2 = p1;
            Console.WriteLine("After copying first product to second, the information for the second product:");
            Console.WriteLine("Code = {0}\nName = {1}\nPrice = {2}", p2.code, p2.productName, p2.price);

            p3.code = "L102";
            p3.productName = "Laptop";
            p3.price = 800.45M;

            Console.WriteLine("Information for the third product:");
            Console.WriteLine("Code = {0}\nName = {1}\nPrice = {2}", p3.code, p3.productName, p3.price);
        }

        public static void Example2()
        {
            var p = new Product2("C102", "Mobile", 85.45M);
            p.Show();
        }

        public static void ArrayExample()
        {
            ProductWithArray p = new ProductWithArray();
            //ProductWithArray p;            
            p.ProductInfo = new string[3];
            p.Code = "K101";
            p.ProductInfo[0] = "Keyboard";
            p.ProductInfo[1] = "8.75$";
            p.ProductInfo[2] = DateTime.Today.ToShortDateString();

            p.Show();
        }

        public static void StructsArrayExample()
        {
            Console.Write("How many products would you like to enter?");
            var n = int.Parse(Console.ReadLine());

            Console.Write("Please enter {0} prdocuts information,", n);
            Product2[] products = new Product2[n];
            for (int i = 0; i < n; i++)
            {
                products[i] = new Product2();

                Console.Write("Enter Code: ");
                products[i].Code = Console.ReadLine();

                Console.Write("Enter Name: ");
                products[i].Name = Console.ReadLine();

                Console.Write("Enter Price: ");
                products[i].Price = decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nThe following products are entered:");
            foreach (var p in products)
            {
                p.Show();
            }
        }

        public static void NestedStructExample1()
        {
            var p = new ProductWithSpec("C101", "Laptop", 865.65M);
            var spec = new ProductWithSpec.Specification("Grey", ".25 pounds", "15 inches");

            p.Show();
            spec.Show();
        }
    }
}
