using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source.boj
{
    class Class2
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("실행중입니당.");
                Console.WriteLine("예외를 두고있습니당");

                throw new Exception("임의의 예외");
                Console.WriteLine("예외 종료");
            }
            catch (FormatException exception)
            {
                Console.WriteLine("임의의 예외가 있습니다.");
            }
            catch

        }
    }
}
