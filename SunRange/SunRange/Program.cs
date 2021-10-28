using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunRange
{
    class Program
    {
        static int sumrange(int x, int y)
        {
            int c = 0;
                for(int i = x; i <= y; i++)
                {
                    c = c + i;
                }
                return c;
        }
        public static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write(sumrange(a, b) + sumrange(b, c));
        }
    }
}
