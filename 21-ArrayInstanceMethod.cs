using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class ArrayInstanceMethod
    {
        static void Main()
        {
            bool[,,] cells;
            cells = new bool[2, 3, 4];
            System.Console.WriteLine(cells.GetLength(0));
        }
    }
}
