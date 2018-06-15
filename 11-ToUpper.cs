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
            string text;

            System.Console.Write("Enter text: ");
            text = System.Console.ReadLine();

            //에러에러 텍스트를 대문자로 변경할 수 없습니당.
            text.ToUpper();

            System.Console.WriteLine(text);
        }
    }
}
