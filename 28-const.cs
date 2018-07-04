using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class Class2
    {
        static void Main()
        {
            const int secondsPerDay = 60 * 60 * 24;
            const int secondsPerweek = secondsPerDay * 7; //const는 지역 상수를 사용할 때 이용됨.
            System.Console.WriteLine(secondsPerweek);
        }
    }
}
