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
            string[] languages = { "c#", "c++", "Cobol", "Java", "visual basic", "pascal", "Fortran", "Lisp", "J#" };
            int[,] cells = new int[3, 3] { { 1, 2, 3 },{ 4, 5, 6 },{ 7, 8, 9 } };

            string language = languages[3];
            languages[3] = languages[2];
            languages[2] = language;
           
        }
    }
}
