using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Interfaces
{
    public interface IRectangle
    {
        void DisplayArea();
    }

    public interface ITriangle
    {
        void DisplayArea();
    }

    public class MultiInterfaceAmbig : IRectangle, ITriangle
    {
        public void DisplayArea()
        {
            Console.WriteLine("Implemeting same method in the multiple interfaces.");
        }
    }

    public class MultiInterfaceExplicit : IRectangle, ITriangle
    {
        void IRectangle.DisplayArea()
        {
            Console.WriteLine("Rectangle: DisplayArea()");
        }

        void ITriangle.DisplayArea()
        {
            Console.WriteLine("Triangle: DisplayArea()");
        }
    }


    public interface IRectInterface
    {
        void DisplayRectArea();
    }

    public interface ITriangleInterface : IRectInterface
    {
        void DisplayTrgArea();
    }

    public class MultiLevelInterface : ITriangleInterface
    {
        public void DisplayRectArea()
        {
            Console.WriteLine("MultiLevelInterface: DisplayRectArea()");
        }

        public void DisplayTrgArea()
        {
            Console.WriteLine("MultiLevelInterface: DisplayTrgArea()");
        }
    }


    public interface IUser
    {
        string Name { get; set; }
        string Email { get; set; }
    }

    public class User : IUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }


    public interface IAllowance
    {
        float HouseAllowance();
    }

    public struct Worker : IAllowance
    {
        public int code, basicSalary;
        public string name;

        public Worker(int c, int s, string n)
        {
            code = c;
            basicSalary = s;
            name = n;
        }

        public float HouseAllowance()
        {
            return (float)6 / 100 * basicSalary;
        }

        public void Show()
        {
            Console.WriteLine("Code: {0}\nBasic Salary: {1}\nWorker Name: {2}",
                code, basicSalary, name);
        }
    }
}
