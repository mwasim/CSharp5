using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Interfaces
{
    public class InterfacesDemo
    {
        public static void Example1()
        {
            var item = new MultiInterfaceAmbig();
            item.DisplayArea();
        }

        public static void ExplicitInterfaces()
        {
            var r = (IRectangle)new MultiInterfaceExplicit();
            var t = (ITriangle)new MultiInterfaceExplicit();

            r.DisplayArea();
            t.DisplayArea();
        }

        public static void VerifyInterfaceImp()
        {
            var item = new MultiInterfaceAmbig();

            if (item is IRectangle)
                Console.WriteLine("MultiInterfaceAmbig Implements IRectangle.");

            var item2 = item as ITriangle;
            if (item2 != null)
                Console.WriteLine("MultiInterfaceAmbig Implements ITriangle.");
        }

        public static void MultiLevelInterfaceExample()
        {
            var item = new MultiLevelInterface();

            item.DisplayRectArea();
            item.DisplayTrgArea();
        }

        public static void InterfacePropertiesExample()
        {
            var user = new User();

            Console.Write("Please enter user's name: ");
            user.Name = Console.ReadLine();

            Console.Write("Please enter user's email: ");
            user.Email = Console.ReadLine();

            Console.Write("\n\nEntered information is as below:\n");
            Console.WriteLine("Name: {0}", user.Name);
            Console.WriteLine("Email: {0}", user.Email);
        }

        public static void StructImpInterface()
        {
            var w = new Interfaces.Worker(101, 5000, "Kelly");

            Console.WriteLine("Worker Information:");
            w.Show();
            Console.WriteLine("Worker's house allowance: {0}", w.HouseAllowance());

            var allowance = w as IAllowance;
            if (allowance != null)
                DisplayWorkAllowance(allowance);
        }


        private static void DisplayWorkAllowance(IAllowance allowance)
        {
            Console.WriteLine("Worker's house allowance: {0}", allowance.HouseAllowance());
        }
    }
}
