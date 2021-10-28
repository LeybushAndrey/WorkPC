using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automorf
{
    class Program
    {
        static void Main(string[] args)
        {
            long k = Convert.ToInt64(Console.ReadLine());
            for (int i = 0; i <= k; i++)
            {
                int j = i;
                long k2 = (long)Math.Pow(i, 2);
                    int c = 0;
                    while (j > 0)
                    {
                        c++;
                        j = j / 10;
                    }
                        if (k2 % (long)Math.Pow(10, c) == i)
                        {
                             Console.Write(i + " ");
                             continue;
                        }
            }
        }
    }
}
