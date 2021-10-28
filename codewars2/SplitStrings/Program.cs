using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitStrings
{
    public class SplitString
    {
        public static string[] Solution(string str)
        {
            string[] solution;
            if (str.Length % 2 == 0)
            {
                solution = new string[str.Length / 2];
                for (int i = 0; i < str.Length/2; i++)
                {
                    for (int j = 0; j < str.Length; j = j + 2)
                    {
                        solution[i] = string.Concat(str[j], str[j + 1]);
                        i++;
                        continue;
                    }
                }

            }

            else
            {
                solution = new string[(str.Length + 1)/2];
                for (int i = 0; i < ((str.Length +1)/2)-1; i++)
                {
                    for (int j = 0; j < str.Length-1; j = j + 2)
                    {
                        solution[i] = string.Concat(str[j], str[j + 1]);
                        i++;
                        continue;
                    }
                }
                solution[((str.Length + 1) / 2) - 1] = str[str.Length - 1] + "_";
            }
            return solution;
        }
    
           
        static void Main(string[] args)
        {
            string str = "abcd";
            Console.WriteLine(Solution(str));
        }
    }
}
