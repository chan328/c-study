using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source.boj
{
    class Class3
    {
        static void Main()
        {
            string firstName;
            string ageText;
            int age;

            Console.WriteLine("이봐요");

            Console.Write("성씨를 대봐요:");
            firstName = System.Console.ReadLine();

            Console.Write("연령을 대봐요:");
            ageText = Console.ReadLine();
            age = int.Parse(ageText);

            System.Console.WriteLine(
                $"안녕 니 성은 {firstName}이고 너는 {age}세구나.");
        }
    }
}
