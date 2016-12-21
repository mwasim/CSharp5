using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Classes
{
    public class A
    {
        public virtual void Disp() { Console.WriteLine("A::Disp()"); }
    }

    public class B : A
    {
        public override void Disp() { Console.WriteLine("B::Disp()"); }
    }

    public class C : A
    {
        public override void Disp() { Console.WriteLine("C::Disp()"); }
    }

    public class D : A
    {
        public virtual void Show() { Console.WriteLine("D::Show()"); }
    }
}
