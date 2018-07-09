using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source.boj
{
    class Class1
    {
        public static void Main(string[] args)
        {
            int totalLineCount = 0;
            string directory;
            if (args.Length > 0)
            {
                directory = args[0];
            }
            else
            {
                directory = Directory.GetCurrentDirectory();
            }
            totalLineCount = DirectoryCountLines(directory);
            System.Console.WriteLine(totalLineCount);
        }
        static int DirectoryCountLines(string directory)
        {
            int lineCount = 0;
            foreach(string file in Directory.GetFiles ("*.cs"))
            {
                lineCount += CountLines(file);
            }

            foreach(string subdirectory in Directory.GetDirectories(directory))
            {
                lineCount += DirectoryCountLines(subdirectory);
            }

            return lineCount;
        }
        private static int CountLines(string file)
        {
            string line;

            int linecount = 0;
            FileStream stream = new FileStream(file, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            line = reader.ReadLine();

            while (line != null)
            {
                if (line.Trim() != "")
                {
                    linecount++;
                }
                line = reader.ReadLine();
            }
            reader.Close();
            return linecount;
        }
    }
}
