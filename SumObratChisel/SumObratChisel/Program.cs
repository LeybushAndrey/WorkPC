using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumObratChisel
{
    class Program
    {
        static int obr(int x)
        {
            int b = 0;
            while (x > 0)
            {
                b = b * 10;
                b = b + x % 10;
                x = x / 10;
            }
            return b;
        }
            public static void Main()
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write(obr(a) + obr(b));
            }
    }
}
