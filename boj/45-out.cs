using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source.boj
{
    class Class1
    {
        static int Main(string[] args)
        {
            char button;

            if(args.Length == 0)
            {
                Console.WriteLine(
                    "ConbertToPhoneNumber.exe <phrase>");
                Console.WriteLine(
                    "'_' indicates no standard phone button");
                return 1;
            }
            foreach(string word in args)
            {
                foreach(char character in word)
                {
                    if(TryGetPhoneButton (character, out button))
                    {
                        Console.Write(button);
                    }
                    else
                    {
                        Console.Write('_');
                    }
                }
            }
            Console.WriteLine();
            return 0;
        }

        static  bool TryGetPhoneButton (char character, out char button)
        {
            bool success = true;
            switch (char.ToLower(character))
            {
                case '1':
                    button = '1';
                    break;
                case '2': case 'a': case 'b': case 'c':
                    button = '2';
                    break;
                case '_':
                    button = '_';
                    break;
                default:
                    button = '_';
                    success = false;
                    break;
            }
            return success;
        }
    }
}
