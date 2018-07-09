using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class Class1
    {
        public static void Main()
        {
            int x = 123;
            System.Console.WriteLine($"{x++}, {x++}, {x}"); // ++을 어디에 붙이냐에 따라 값이 올라가는 때가 다름.
            System.Console.WriteLine($"{++x}, {++x}, {x}");
        }
    }
}
