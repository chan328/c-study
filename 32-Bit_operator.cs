using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class Class1
    {
        static void Main()
        {
            const int size = 64;
            ulong value;
            char bit;

            System.Console.Write("integer를 입력하세요");
            value = (ulong)long.Parse(System.Console.ReadLine());

            ulong mask = 1UL << size - 1;
            for (int count = 0; count < size; count++)
            {
                bit = ((mask & value) != 0) ? '1' : '0';
                System.Console.Write(bit);
                mask >>= 1;
            }
            System.Console.WriteLine();
        }
    }
}
