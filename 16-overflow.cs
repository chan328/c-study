using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class overflow
    {
        public static void Main()
        {
            unchecked
            {
                //int.MaxVaule는 2147483647이당.
                int n = int.MaxValue;
                n += 1;
                System.Console.WriteLine(n);
            }
        }
    }
}
