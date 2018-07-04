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
            string first;
            string last;

            System.Console.WriteLine("이봐요!");

            System.Console.Write("성씨를 대봐요!");
            first = System.Console.ReadLine();

            System.Console.Write("이름을 대봐요!");
            last = System.Console.ReadLine();

            System.Console.WriteLine(
                $"당신의 이름은 {first} {last} (이)군요!");
        }
    }
}
