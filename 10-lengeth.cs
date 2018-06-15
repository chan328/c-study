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
                + $" {palindrome.Length} characters."
                );
        }
    }
}
