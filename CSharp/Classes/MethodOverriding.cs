using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Classes.MethodOverriding
{
    public class Rectangle
    {
        protected float x, y;

        public void SetRectangle(float a, float b)
        {
            x = a;
            y = b;
        }

        public virtual float Area()
        {
            return x * y;
        }
    }

    public class Triangle : Rectangle
    {
        public void SetTriangle(float a, float b)
        {
            x = a;
            y = b;
        }

        public override float Area()
        {
            return (float)1 / 2 * x * y;
        }
    }


    public class Worker
    {
        protected int code, basicSalary;
        private float houseAllowance;
        protected string name;

        public void SetWorker(int c, int b, string n)
        {
            code = c;
            basicSalary = b;
            name = n;
        }

        public virtual void HouseholdAllowance()
        {
            houseAllowance = (float)6 / 100 * basicSalary;
            Console.WriteLine("Household allowance: {0}", houseAllowance);
        }

        public void ShowWorker()
        {
            Console.WriteLine("Code: {0}, Name: {1}, Salary: {2}", code, name, basicSalary);
        }
    }

    public class Officer : Worker
    {
        private float houseAllowance;

        public void SetOfficer(int c, int b, string n)
        {
            SetWorker(c, b, n);
        }

        public new void HouseholdAllowance()
        {
            houseAllowance = (float)8 / 100 * basicSalary;
            Console.WriteLine("Household allowance: {0}", houseAllowance);
        }

        public void ShowOfficer()
        {
            ShowWorker();
        }
    }
}


namespace CSharp.Classes.MultiOverriding
{
    public class Worker
    {
        protected int code, basicSalary;
        protected float houseAllowance;
        protected string name;

        public Worker(int c, int b, string n)
        {
            code = c;
            basicSalary = b;
            name = n;
        }

        public void ShowWorker()
        {
            Console.WriteLine("Code: {0}, Name: {1}, Salary: {2}", code, name, basicSalary);
        }

        public virtual void HouseholdAllowance()
        {
            houseAllowance = (float)6 / 100 * basicSalary;
            Console.WriteLine("Household allowance: {0}", houseAllowance);
        }
    }

    public class Officer : Worker
    {
        public Officer(int c, int b, string n) : base(c, b, n) { }

        public override void HouseholdAllowance()
        {
            houseAllowance = (float)8 / 100 * basicSalary;
            Console.WriteLine("Household allowance: {0}", houseAllowance);
        }
    }

    public class Manager : Officer
    {
        public Manager(int c, int b, string n) : base(c, b, n) {}

        public override void HouseholdAllowance()
        {
            houseAllowance = (float)10 / 100 * basicSalary;
            Console.WriteLine("Household allowance: {0}", houseAllowance);
        }
    }
}