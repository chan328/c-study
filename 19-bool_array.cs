using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class Class2
    {
        static void Main()
        {
            bool[,,] cells;
            cells = new bool[2, 3, 3]
            {
                {
                    {true, false, false },
                    {true, false, false },
                    {true, false, true }
                },
                {
                    { false, false, true },
                    { false, true, false },
                    { false, true, true }
                }
            };
        }
    }
}
