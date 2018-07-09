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
            string palindrome;

            System.Console.Write("enter a palindrome");
            palindrome = System.Console.ReadLine();

            System.Console.WriteLine(
                $"ther palindrome \" {palindrome} \"is"
                + $" {palindrome.Length} characters." // .length를 뒤에 붙이면 .length 앞의 변수의 길이를 재줌.
                );
        }
    }
}
