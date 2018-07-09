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
            System.Console.Write("Enter text: ");
            var text = System.Console.ReadLine();

            var uppercase = text.ToUpper(); // var는 뒤에 오는 변수의 형태를 자동으로 정해줌
             // .ToUpper();를 사용하면 대문자로 변경된다!
            System.Console.WriteLine(uppercase);
        }
    }
}
