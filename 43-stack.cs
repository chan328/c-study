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
            string fullName;
            string driveLetter = "C:";
            string folderPath = "Data";
            string fileName = "index.html";

            fullName = combine(driveLetter, folderPath, fileName);

            Console.WriteLine(fullName);
        }
        static string combine(
            string driveLetter, string folderPath, string fileName)
        {
            string path;
            path = string.Format("{1} {0} {2} {0} {3}",
                System.IO.Path.DirectorySeparatorChar,
                driveLetter, folderPath, fileName);
            return path;
        }
    }
}
