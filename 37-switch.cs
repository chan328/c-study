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
            bool valid = false;
            string Input;

            Input = System.Console.ReadLine();

            switch (Input)
            {
                case "1":
                case "2":
                case "3":

                    valid = true;
                    break;
                case "quit":
                    valid = true;
                    break;
                default:
                    System.Console.Write("유효하지 않습니당.");
                    break;

            }
        }
    }
}
