using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class Class2
    {
        static void Main(string[] args)
        {
            string input;
            bool result;
            string message;
            int playercount;
            System.Console.Write("플레이어 수를 입력하세요 1p or 2p");
            playercount = int.Parse(System.Console.ReadLine());
            if (playercount != 1 && playercount !=2)
            {
                message =
                    "잘못된 수를 입력하셨습니다.";
            }
            else
            {
                message =
                    "제대로 된 수를 입력하셨습니다.";
                System.Console.WriteLine("모드를 선택하세요 quit / play");
                input = System.Console.ReadLine();
            }
            System.Console.WriteLine(message);
        }
    }
}
