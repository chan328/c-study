using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class Class1
    {
        const string TEXT = " 변수의 값: "; // readonly와 비슷하지만 runtime때 절대로 변경 불가능.

        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;

            System.Console.WriteLine("x" + TEXT + x);
            System.Console.WriteLine("y" + TEXT + y);
        }
    }
}
