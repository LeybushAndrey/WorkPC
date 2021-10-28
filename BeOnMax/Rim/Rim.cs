using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rim
{
    class Rim
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите римское число:");

            string RimNumber = Console.ReadLine();

            int[] Number = new int[RimNumber.Length];
            int result = 0;

            for (int i = 0; i < RimNumber.Length; i++)
            {
                switch (RimNumber[i])
                {
                    case 'I':
                        Number[i] = 1;
                        break;
                    case 'V':
                        Number[i] = 5;
                        break;
                    case 'X':
                        Number[i] = 10;
                        break;
                    case 'L':
                        Number[i] = 50;
                        break;
                    case 'C':
                        Number[i] = 100;
                        break;
                    case 'D':
                        Number[i] = 500;
                        break;
                    case 'M':
                        Number[i] = 1000;
                        break;
                }
                    if (i+1 < RimNumber.Length && Number[i] < Number[i + 1])
                    {
                        result = result - Number[i];
                    }
                    else
                    {
 
                    }
            }
            Console.WriteLine(result);
        }
    }
}
