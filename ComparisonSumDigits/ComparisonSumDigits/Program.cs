using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonSumDigits
{
    class Program
    {
        static int com(int x)
        {
            int c = 0;
            while(x > 0)
            {
                int b = x % 10;
                c = c + b;
                x = x / 10;
            }
                return c;
        }
        public static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if(com(a) > com(b))
            {
                Console.Write("1");
            }
            else
            {
                if(com(a) < com(b))
                {
                    Console.Write("2");
                }
                else
                    Console.Write("0");
            }
        }
    }
}
