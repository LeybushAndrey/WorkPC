using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumRyad
{
    class Program
    {
        static double sumrange(int x)
        {
            double c = 0;
            int f = 1;
            for (int i = 1; i <= 5; i++)
            {
                f = f * i;
                c = c + (i * (-1) * ((double)x / (double)f));
            }
            return c;
        }
        public static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write(sumrange(a));
        }
    }
}
