using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.OperatorOverloading
{
    public class Complex
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        public Complex(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }


        public static Complex operator +(Complex c1, Complex c2)
        {
            var c = new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);

            return c;
        }

        public override string ToString()
        {
            return (String.Format("{0} + {1}i", Real, Imaginary));
        }
    }
}
