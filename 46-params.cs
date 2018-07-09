using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source.boj
{
    class Class2
    {
        static void Main()
        {
            string fullName;

            fullName = combine(
                Directory.GetCurrentDirectory(),
                "bom", "config", "index.html");
            Console.WriteLine(fullName);

            fullName = combine(
                Environment.SystemDirectory,
                "temp", "index.html");
            Console.WriteLine(fullName);

            fullName = combine(
                new string[] {
                "C:\\", "Data",
                "HomeDir", "index.html"});
            Console.WriteLine(fullName);
        }
        static string combine(params string[] paths)
        {
            string result = string.Empty;
            foreach (string path in paths)
            {
                result = System.IO.Path.Combine(result, path);
            }
            return result;
        }
    }
}
