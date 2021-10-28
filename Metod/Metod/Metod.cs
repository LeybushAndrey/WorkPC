using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metod
{
    class Metod
    {
        static void PrintString(string s, uint x)
        {
            for(int i = 0; i < x; i++)
            Console.Write(s);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ");
            string symbol = Console.ReadLine();
            Console.WriteLine("Введите количество символов");
            uint symbolsCount = uint.Parse(Console.ReadLine()); 
            PrintString(symbol, symbolsCount);
        }
    }
}
