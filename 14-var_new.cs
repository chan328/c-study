using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CSharpStudy.source
{
    class Class1
    {

        static void Main()
        {
            var patent1 =
                    new
                    {
                        Title = "Bifoclas",
                        YearOfPublication = "1784"
                    };
            var patent2 =
                           new
                           {
                               Title = "Phonograph",
                               YearOfPublication = " 1877"
                           }; // new를 사용해서 새로운 인스턴스를 형성할 수 있다.

            System.Console.WriteLine(
                      $"{patent1.Title} ({patent1.YearOfPublication})");
            System.Console.WriteLine(
                      $"{patent2.Title} ({patent2.YearOfPublication})");
        }
    }
}