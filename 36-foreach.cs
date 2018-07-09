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
            char[] cells =
            {
                '1', '2', '3', '4', '5', '6', '7', '8', '9'
            };

            System.Console.Write(
                "The available moves are as follows: ");

            foreach (char cell in cells) // 변수 in 배열
            {
                if (cell != '0' && cell != 'X')
                {
                    System.Console.Write($"{cell}");
                }
            }
        }
    }
}
