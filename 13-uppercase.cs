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

            var uppercase = text.ToUpper();

            System.Console.WriteLine(uppercase);
        }
    }
}
