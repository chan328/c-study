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
            System.Console.WriteLine($"{x++}, {x++}, {x}");
            System.Console.WriteLine($"{++x}, {++x}, {x}");
        }
    }
}
