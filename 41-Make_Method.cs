using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class Class2
    {
        public static void Main()
        {
            string first;
            string last;
            string full;
            string init;

            System.Console.WriteLine("저기요!");
            first = GetUserInput("성을 쓰세연: ");
            last = GetUserInput("이름을 쓰세연: ");

            full = GetFullName(first, last);
            init = GetInitials(first, last);
            DisplayGreeting(full, init);
        }
        static string GetUserInput(string prompt)
        {
            System.Console.Write(prompt);
            return System.Console.ReadLine();
        }
        static string GetFullName(string first, string last)
            => $"{first} {last}";

        static void DisplayGreeting(string full, string init)
        {
            System.Console.WriteLine(
            $"안녕 {full} 너의 이니셜은 {init}");
            return;
        }
        static string GetInitials(string first, string last)
        {
            return $"{first[0]}. {last[0]}.";
        }
    }
    }
