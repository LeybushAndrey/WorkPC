using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangram
{
    class Ispangram
    {

        public static bool IsPangram(string str)
        {
            char[] s = str.ToLower().ToCharArray();
            List<char> alphabet = new List<char>();
            for (int i = 97; i < 123; i++)
            {
                alphabet.Add((char)i);
            }
            int count = alphabet.Count;
            for (int j = 0; j < alphabet.Count; j++)
            {
                for (int k = 0; k < s.Length; k++)
                {
                    if (alphabet[j] == s[k])
                    {
                        count--;
                        break;
                    }
                    else
                        continue;
                }
            }
            if (count == 0)
                return true;
            else
                return false;
        }
        
        static void Main(string[] args)
        {
            string str = "The quick brown fox jumps over the lazy dog.";
            if (IsPangram(str))
            Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
    }
}
