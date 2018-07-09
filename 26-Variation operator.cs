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
            char current;
            int unicodeValue;

            current = 'z';

            do
            {
                unicodeValue = current;
                System.Console.Write($"{current} = {unicodeValue}\t");
                current--;
            } while (current >= 'a'); // do while문 : while문 안의 내용을 한번 실행하고 조건문 검사
        }
    }
}
