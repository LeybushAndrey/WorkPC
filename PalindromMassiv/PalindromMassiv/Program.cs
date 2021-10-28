using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromMassiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // сколько чисел будут вводиться на следующей строке
            string s = Console.ReadLine(); // сохранить все введенную строку
            string[] ss = s.Split(' '); // разделить введенную строку по пробелам и сохранить в массив строкового типа
            int length = ss.Length;
            int c = 0;
            int k = 0;
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                int number = Convert.ToInt32(ss[i]);
                numbers[i] = number;
            }
                for (int i = 0; i < length / 2; i++)
                {
                    if(numbers[i] == numbers[n - 1 - k])
                    {
                         c++;
                          k++;
                    continue;
                    }
                    else
                    {
                    c = 0;
                    break;
                    }
                }
            if (n <= 1)
            {
                Console.Write("YES");
            }
            else
            {
                if (c == 0)
                {
                    Console.Write("NO");
                }
                else
                {
                    Console.Write("YES");
                }
            }    
        }
    }
}
