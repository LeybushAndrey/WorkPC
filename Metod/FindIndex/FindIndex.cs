using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindIndex
{
    class FindIndex
    {
        static int Index(int [] arr, int a)
        {
         int index = Array.IndexOf(arr, a);
            return index;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, -55, 1, 8, 98 };
            Console.WriteLine("Введите искомый элемент массива:");
            int x = int.Parse(Console.ReadLine());
            int index = Index(arr, x);
            if(index >= 0)
            Console.WriteLine("Индекс искомого элемета массива: " + index);
            else
                Console.WriteLine("Искомый элемет массива не найден!");
            Console.ReadLine();
        }
    }
}
