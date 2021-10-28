using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StopGninnipSMySdroW
    {
        public static string SpinWords(string sentence)
        {
            return string.Join(" ", sentence.Split(' ').Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str));
            //string spin = "";
            //string[] ss = sentence.Split(' ');
            //for (int i = 0; i < ss.Length; i++)
            //{
            //    if (ss[i].Length < 5)
            //    {
            //        if (i == ss.Length - 1)
            //            spin = spin + ss[i];
            //        else
            //            spin = spin + ss[i] + " ";
            //    }
                    
            //    else
            //    {
            //        string str = new string (ss[i].Reverse().ToArray());
            //        if (i == ss.Length - 1)
            //            spin = spin + str;
            //        else
            //            spin = spin + str + " ";
            //    }
            //}
            //return spin;
        }

        static void Main(string[] args)
        {
            string str = "Hey fellow warriors";
            Console.WriteLine(SpinWords(str));
        }
    }
}
