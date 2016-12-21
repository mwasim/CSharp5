using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.AbstractClasses
{
    public abstract class Shape
    {
        protected float breadth, length;
        public Shape(float a, float b)
        {
            breadth = a;
            length = b;
        }

        public abstract float Area();

        public abstract float Length { get; set; }
        public abstract float Breadth { get; set; }
    }

    public class Rectangle : Shape
    {
        public Rectangle(float a, float b) : base(a, b) { }

        public override float Breadth
        {
            get
            {
                return breadth;
            }

            set
            {
                breadth = value;
            }
        }

        public override float Length
        {
            get
            {
                return length;
            }

            set
            {
                length = value;
            }
        }

        public override float Area()
        {
            return breadth * length;
        }
    }

    public class Triangle : Shape
    {
        public Triangle(float a, float b) : base(a, b)
        {

        }

        public override float Area()
        {
            return (float)1 / 2 * breadth * length;
        }

        public override float Breadth
        {
            get
            {
                return breadth;
            }

            set
            {
                breadth = value;
            }
        }

        public override float Length
        {
            get
            {
                return length;
            }

            set
            {
                length = value;
            }
        }
    }
}
