using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braces
{
    class Braces
    {
            public static bool validBraces(String braces)
            {
            //if (braces.Length % 2 != 0)
            //{
            //    return false;
            //}
            //else
            //{
            //    for (int i = 0; i < braces.Length / 2; i++)
            //    {
            //        for (int j = braces.Length - 1; j >= 0; j--)
            //        {

            //        }
            //    }
            //}

            //return false;
            var stack = new Stack<char>();
            foreach (var c in braces)
            {
                switch (c)
                {
                    case '{':
                    case '(':
                    case '[':
                        stack.Push(c);
                        break;
                    case '}':
                        if (stack.Count == 0)
                            return false;
                        if (stack.Pop() != '{')
                            return false;
                        break;
                    case ']':
                        if (stack.Count == 0)
                            return false;
                        if (stack.Pop() != '[')
                            return false;
                        break;
                    case ')':
                        if (stack.Count == 0)
                            return false;
                        if (stack.Pop() != '(')
                            return false;
                        break;
                }
            }
            return stack.Count == 0;
        }

            static void Main(string[] args)
            {
            string braces = "(()[{}])";
            if(validBraces(braces))
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
            }
    }
}
