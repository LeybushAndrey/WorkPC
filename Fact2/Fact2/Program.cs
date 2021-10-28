using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fact2
{
    class Program
    {
        static int fact(int x)
        {
            int c = 1;
            if ((x + 1) % 2 == 0)
            {
                for (int i = 1; i <= x; i = i + 2)
                {
                    c = c * i;
                }
                return c;
            }
            else
            {
                for (int i = 2; i <= x; i = i + 2)
                {
                    c = c * i;
                }
                return c;
            }
        }
        public static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write(fact(a) + " " + fact(b) + " " + fact(c));
        }
    }
}
