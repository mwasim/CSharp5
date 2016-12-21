using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Classes
{
    public class StaticMember
    {
        public static int x = 10;
        public static int y;

        public StaticMember(int a, int b)
        {
            x = a;
            y = b;
        }

        public int Sum()
        {
            return x + y;
        }

        public int Multiplication()
        {
            return x * y;
        }
    }
}
