using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Classes
{
    public class Worker
    {
        protected int code, basicSalary;
        protected string name;

        public void SetWorker(int c, int b, string n)
        {
            code = c;
            basicSalary = b;
            name = n;
        }

        public void ShowWorker()
        {
            Console.WriteLine("Code: {0}, Name: {1}, Salary: {2}", code, name, basicSalary);
        }
    }

    public class Officer : Worker
    {
        private float houseAllowance, childAllowance;

        public void SetOfficer(int c, int b, string n)
        {
            SetWorker(c, b, n);
            houseAllowance = (float)6 / 100 * basicSalary;
            childAllowance = 250;
        }

        public void ShowOfficer()
        {
            ShowWorker();
            Console.WriteLine("Household allowance: {0}, Child allowance: {1}", houseAllowance, childAllowance);
        }
    }

    public class Manager : Officer
    {
        private float expatAllowance, carAllowance;

        public void SetManager(int c, int b, string n)
        {
            SetOfficer(c, b, n);
            expatAllowance = (float)basicSalary * 16 / 100;
            carAllowance = 150;
        }


        public void ShowManager()
        {
            ShowOfficer();
            Console.WriteLine("Expatriation allowance: {0}, Car allowance: {1}", expatAllowance, carAllowance);
        }
    }

    public class Director : Manager
    {
        private float medicalAllowance, cityAllowance;

        public void SetDirector(int c, int b, string n)
        {
            SetManager(c, b, n);
            medicalAllowance = (float)basicSalary * 25 / 100;
            cityAllowance = (float)basicSalary * 10 / 100;
        }

        public void ShowDirector()
        {
            ShowManager();
            Console.WriteLine("Medical allowance: {0}, City allowance: {1}", medicalAllowance, cityAllowance);
        }
    }
}
