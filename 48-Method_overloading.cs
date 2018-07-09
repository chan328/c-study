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
            int totalLinecount;
            if (args.Length > 1)
            {
                totalLinecount = DirectoryCountLines(args[0], args[1]);
            }
            if (args.Length > 0)
            {
                totalLinecount = DirectoryCountlines(args[0]);
            }
            else
            {
                totalLinecount = DirectoryCountlines();
            }
            System.Console.WriteLine(totalLinecount);
        }

        static int DirectoryCountlines()
        {
            return DirectoryCountlines(Directory.GetCurrentDirectory());
        }

        static int DirectoryCountlines(string directory)
        {
            return DirectoryCountLines(directory, "*.cs");
        }

        static int DirectoryCountLines(string directory, string extension)
        {
            int linecount = 0;
            foreach(string file in Directory.GetFiles(directory, extension))
            {
                linecount += CountLines(file);
            }

            foreach(string subdirectory in Directory.GetDirectories(directory))
            {
                linecount += DirectoryCountlines(subdirectory);
            }
            return linecount;
        }

        private static int CountLines (string file)
        {
            int linecount = 0;
            string line;
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
