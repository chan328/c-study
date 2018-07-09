using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source.boj
{
    class Class2
    {
        static int Main()
        {
            string firstName;
            string ageText;
            int age;
            int result = 0;

            Console.Write("성씨를 입력하세여: ");
            firstName = System.Console.ReadLine();

            Console.Write("나이를 입력하세여: ");
            ageText = System.Console.ReadLine();

            try
            {
                age = int.Parse(ageText);
            }
            finally
            {
                Console.WriteLine($"Goodbye {firstName}");
            }

            return result;
        }
    }
}
