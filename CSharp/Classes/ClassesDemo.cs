using CSharp.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Classes
{
    public class ClassesDemo
    {
        public static void CallingConstructorFromTheConstrutor()
        {
            var s1 = new Student(101, "Kelly", 1000);
            var s2 = new Student(102, "Jessy", 1000, 200);
            var s3 = new Student(103, "Caroline", 1000, 200, 350);

            Console.WriteLine("\n\nFirst Student:");
            s1.Show();
            Console.WriteLine("\n\nSecond Student:");
            s2.Show();
            Console.WriteLine("\n\nThird Student:");
            s3.Show();
        }

        public static void GabageCollectionDemo()
        {
            var r = new RectArea(5, 8);
            Console.WriteLine("Area: {0}", r.GetRect());
            r = null;
        }


        public static void StaticMemberExample()
        {
            Console.WriteLine("Initial Values, X: {0}, Y: {1}", StaticMember.x, StaticMember.y);

            var sm = new StaticMember(25, 50);
            Console.WriteLine("Changed Values, X: {0}, Y: {1}", StaticMember.x, StaticMember.y);

            Console.WriteLine("SUM of X: {0}, Y: {1} => {2}", StaticMember.x, StaticMember.y, sm.Sum());
            Console.WriteLine("MULTIPLICATION of X: {0}, Y: {1} => {2}", StaticMember.x, StaticMember.y, sm.Multiplication());
        }


        public static void SingleInheritanceExample()
        {
            var r = new Triangle();

            r.SetRectangle(5, 8);
            r.SetTriangle(19, 7);

            Console.WriteLine("Rectangle Area: {0}", r.RectangleArea());
            Console.WriteLine("Triangle Area: {0}", r.GetTriangleArea());
        }

        public static void HybridInheritanceExample()
        {
            var w = new Worker();
            var o = new Officer();
            var m = new Manager();
            var d = new Director();

            w.SetWorker(101, 5000, "Kelly");
            o.SetOfficer(102, 7000, "Jessy");
            m.SetManager(103, 9000, "Caroline");
            d.SetDirector(104, 12000, "Wasim");

            Console.WriteLine("Worker Information:");
            w.ShowWorker();
            Console.WriteLine("\nOfficer Information:");
            o.ShowOfficer();
            Console.WriteLine("\nManager Information:");
            m.ShowManager();
            Console.WriteLine("\nDirector Information:");
            d.ShowDirector();

        }

        public static void MethodOverridingExample()
        {
            var r = new MethodOverriding.Rectangle();
            var t = new MethodOverriding.Triangle();

            r.SetRectangle(5, 8);
            t.SetTriangle(6, 3);

            Console.WriteLine("Rectangle Area: {0}", r.Area());
            Console.WriteLine("Triangle Area: {0}", t.Area());

            Console.WriteLine();
            var w = new MethodOverriding.Worker();
            var o = new MethodOverriding.Officer();

            w.SetWorker(101, 5000, "Kelly");
            o.SetOfficer(102, 7000, "Caroline");

            w.ShowWorker();
            w.HouseholdAllowance();
            o.ShowOfficer();
            o.HouseholdAllowance();
        }

        public static void MultiMethodOverriding()
        {
            var w = new MultiOverriding.Worker(101, 5000, "Kelly");
            var o = new MultiOverriding.Officer(102, 7000, "Caroline");
            var m = new MultiOverriding.Manager(102, 9000, "Jessica");

            Console.WriteLine("Worker Information: ");
            w.ShowWorker();
            w.HouseholdAllowance();

            Console.WriteLine("\nOfficer Information: ");
            o.ShowWorker();
            o.HouseholdAllowance();

            Console.WriteLine("\nManager Information: ");
            m.ShowWorker();
            m.HouseholdAllowance();
        }

        public static void AbstractClassesExample()
        {
            Shape r = new AbstractClasses.Rectangle(8, 5);
            Shape t= new AbstractClasses.Triangle(9, 7);

            Console.WriteLine("Rectangle Area: {0}, Breadth = {1}, Length = {2}", r.Area(), r.Breadth, r.Length);
            Console.WriteLine("Triangle Area: {0}", t.Area());
        }

        public static void PolymorphExample1()
        {
            A a = new A();
            A b = new B();
            A c = new C();
            A d = new D();

            a.Disp();
            b.Disp();
            c.Disp();
            d.Disp();
        }
    }
}
