using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.OperatorOverloading
{
    public class Inches
    {
        public Inches()
        {

        }

        public Inches(int n)
        {
            Inch = n;
        }
        public int Inch { get; set; }

        public static explicit operator Inches(int feet)
        {
            var obj = new Inches();
            obj.Inch = feet * 12; //12 inches per feet

            return obj;
        }

        public static implicit operator int(Inches obj)
        {
            return obj.Inch / 12; //one feet  = 12 inches
        }

        public override string ToString()
        {
            return Inch.ToString();
        }
    }
}
