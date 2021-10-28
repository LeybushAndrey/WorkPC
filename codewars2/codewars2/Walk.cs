using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars2
{
    class Walk
    {

        public static bool IsValidWalk(string[] walk)
        {
            return walk.Count(x => x == "n") == walk.Count(x => x == "s") && walk.Count(x => x == "e") == walk.Count(x => x == "w") && walk.Length == 10;
            //            int result = 0;
            //            int ax = 0;
            //            if (walk.Length != 10)
            //                return false;
            //            for (int i = 0; i < walk.Length; i++)
            //            {
            //                if (walk[i] == "n")
            //                    ax = 1;
            //                if (walk[i] == "s")
            //                    ax = -1;
            //                if (walk[i] == "w")
            //                    ax = 2;
            //                if (walk[i] == "e")
            //                    ax = -2;
            //
            //              result += ax;
            //            }
            //            return result == 0;
        }


        static void Main(string[] args)
        {
            string[] walk = {""};
            Console.WriteLine(IsValidWalk(walk));
        }
    }
}
