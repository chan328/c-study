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
            int a = '3' + '4'; 
            char b = (char)a; // int형 a를 앞에(char)를 붙여서 형변환을 시켜줌.
            System.Console.WriteLine(b);

            int c = 'f' - 'c';
            System.Console.WriteLine(c);
        }
    }
}
