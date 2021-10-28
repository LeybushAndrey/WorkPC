using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static string who = "class";

        static void F()
        {
            string who = "F";
        }

        static void G()
        {
            F();
            Console.WriteLine(who);
        }

        static void H()
        {
            string who = "H";
            F();
            Console.Write(who);
        }
    }
}
