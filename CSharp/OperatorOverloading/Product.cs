using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.OperatorOverloading
{
    public class Product
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Product()
        {

        }

        public Product(int qty, decimal price)
        {
            Quantity = qty;
            Price = price;
        }

        public static Product operator +(Product p1, Product p2)
        {
            var prod = new Product();

            prod.Price = p1.Price + p2.Price;
            prod.Quantity = p1.Quantity + p2.Quantity;

            return prod;
        }

        public static Product operator +(Product p1, int num)
        {
            var prod = new Product();

            prod.Quantity = p1.Quantity + num;
            prod.Price = p1.Price + num;

            return prod;
        }

        public static Product operator +(int num, Product p1)
        {
            var prod = new Product();

            prod.Quantity = p1.Quantity + num;
            prod.Price = p1.Price + num;

            return prod;
        }

        public static Product operator ++(Product p)
        {
            p.Quantity++;
            p.Price++;

            return p;
        }

        public static Product operator --(Product p)
        {
            p.Quantity--;
            p.Price--;

            return p;
        }

        public static bool operator true(Product p)
        {
            return (p.Quantity != 0);
        }

        public static bool operator false(Product p)
        {
            return (p.Quantity == 0);
        }

        public static bool operator !(Product p)
        {
            return (p.Quantity == 0);
        }

        public static bool operator ==(Product p1, Product p2)
        {
            return (p1.Quantity == p2.Quantity);
        }

        public static bool operator !=(Product p1, Product p2)
        {
            return (p1.Quantity != p2.Quantity);
        }

        public static bool operator ==(Product p, bool b)
        {
            if (b) return p.Quantity != 0; //true means, quantity is non zero
            return false;
        }

        public static bool operator !=(Product p, bool b)
        {
            if (b) return p.Quantity == 0;//false means, quanity is zero
            return false;
        }

        public static bool operator <(Product p1, Product p2)
        {
            return (p1.Quantity < p2.Quantity);
        }

        public static bool operator >(Product p1, Product p2)
        {
            return (p1.Quantity > p2.Quantity);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;

            var prod = (Product)obj;
            return Quantity.Equals(prod.Quantity);            
        }

        public override int GetHashCode()
        {
            return Quantity.GetHashCode();
        }

        public void Show()
        {
            Console.WriteLine("Product Information: Quanity: {0}, Price: ${1}", Quantity, Price);
        }
    }
}
