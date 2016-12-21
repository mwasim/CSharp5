using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Classes
{
    public class Student
    {
        private int Id, tutionFees;
        decimal totalFees;
        private string name;

        public Student(int u, string v, int w)
        {
            Id = u;
            name = v;
            tutionFees = w;
            totalFees = w;
        }

        public Student(int u, string v, int w, int x) : this(u, v, w)
        {
            //x = library fee
            totalFees = w + x;
        }

        public Student(int u, string v, int w, int x, int y) : this(u, v, w)
        {
            //y = boarding fee
            totalFees = w + x + y;
        }

        public void Show()
        {
            Console.WriteLine("Student Information:");
            Console.Write("ID: {0}\nName: {1}\nTution Fee: {2}\nTotal Fee: {3}",
                Id, name, tutionFees, totalFees);
        }
    }

   
}
