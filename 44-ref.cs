using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source.boj
{
    class Class1
    {
        static void Main()
        {
            string first = "hello";
            string second = "goodbye";
            Swap(ref first, ref second);

            Console.WriteLine(
                $@"first = ""{first}"", second = ""{second}""");
        }
        static void Swap(ref string x, ref string y)
        {
            string temp = x;
            x = y;
            y = temp;
        }
    }
}
