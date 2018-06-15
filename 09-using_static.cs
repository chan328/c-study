using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CSharpStudy.source
{
    class Class1
    {
        static void Main()
        {
            string firstName;
            string lastName;

            WriteLine("Hey you!");
            Write("Enter your first name: ");
            firstName = ReadLine();

            Write("Enger your last name: ");
            lastName = ReadLine();

            WriteLine(
                $"Your full name is {firstName} {lastName}."
            );
        }
    }
}
