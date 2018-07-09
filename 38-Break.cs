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
            int winner = 0;
            int[] playerPostion = { 0, 0 };

            playerPostion[0] = 449;
            playerPostion[1] = 28;

            int[] winnerMasks =
            {
                7, 56, 448, 73, 146, 292, 84, 273
            };
            foreach(int mask in winnerMasks)
            {
                if ((mask & playerPostion[0]) == mask)
                {
                    winner = 1;
                    break; // 사용시 foreach문 탈출!
                }
                else if ((mask & playerPostion[1]) == mask)
                {
                    winner = 2;
                    break;
                }
            }
            System.Console.WriteLine($"the winner is {winner}");
        }
    }
}
