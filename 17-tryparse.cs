using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class tryparse
    {
        static void Main()
        {
            double number;
            string input;

            System.Console.Write("숫자를 입력하세용");
            input = System.Console.ReadLine();

            if(double.TryParse(input, out number))
            {
                //변환 성공, 이제 숫자를 사용
                //...
            }
            else
            {
                System.Console.WriteLine(
                    "입력한 텍스트는 유효하지 않습니다.");
            }
        }
    }
}
