using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class Do_while
    {
        static void Main()
        {
            int currentPlayer = 10;
            bool valid;
            do
            {
                string input;
                valid = false;
                System.Console.Write(
                    $"\nPlayer {currentPlayer} : Enter move :");
                input = System.Console.ReadLine();
            } while (!valid);
        }
    }
}
