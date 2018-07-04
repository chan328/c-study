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
            string input;

            // 사용자에게 1p 2p 플레이어 게임을 선택시킴
            System.Console.WriteLine("1p 2p를 선택하세요");

            input = System.Console.ReadLine();

            if (input == "1")
            {
                System.Console.WriteLine("1p를 선택하셨습니다.");
            }
            else if (input == "2")
            {
                System.Console.WriteLine("2p를 선택하셨습니다.");
            }
        }
    }
}
