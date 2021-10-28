using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightForWeight
{
    class Break
    {
        public static string BreakCamelCase(string str)
        {
            var res = str.ToCharArray().Select(x => char.IsUpper(x) ? " " + x : "" + x).ToList();
            string newStr = string.Join("", res);
            return newStr;
        }

        static void Main(string[] args)
        {
            string str = "camelCasing";
            Console.WriteLine(BreakCamelCase(str));
        }
    }
}
