using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class arraysort
    {
        static void Main()
        {
            int[] arr = { 1, 3, 2, 4, 5, 6, 8, 7 };
            System.Array.Sort(arr);
            foreach (var value in arr)
            {
                Console.WriteLine("정렬 배열 - {0}", value);
            }
        }
    }
}
