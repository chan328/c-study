using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class Class1
    {
        static int Main(string[] arg)
        {
            int result;
            string targetFileName;
            string url;
            switch (arg.Length)
            {
                default:
                    System.Console.WriteLine("ERROR: You must specify the"
                        + "URL and the file name");
                    targetFileName = null;
                    url = null;
                    break;
                case 2:
                    url = arg[0];
                    targetFileName = arg[1];
                    break;
            }
            if (targetFileName != null && url != null)
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile(url, targetFileName);
                result = 0;
            }
            else
            {
                System.Console.WriteLine("Usage: Downloader.exe <URL> <TargetFileName>");
                result = 1;
            }
            return result;
        }
    }
}
