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
            string reverse, palindrome;
            char[] temp;

            System.Console.Write("회문을 입력하세요");
            palindrome = System.Console.ReadLine();

            reverse = palindrome.Replace(" ", "");
            reverse = reverse.ToLower();

            temp = reverse.ToCharArray();

            System.Array.Reverse(temp);

            if(reverse == new string(temp)) //입력받은 회문은 반대로 뒤집어서 비교함
            {
                System.Console.WriteLine(
                    $"\"{palindrome}\"은 회문입니다."
                    );
            }
            else
            {
                System.Console.WriteLine(
                    $"\"{palindrome}\"은 회문이 아닙니다."
                    );
            }
        }
    }
}
