using System;
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
            DisPlayGreeting(
               firstName: "Indigo", lastName: "Montoya" // indigo는 first Name칸에 Montoya는 lastName으로 들어가진다! 이것이 선택적 매개변수의 힘!
                );
        }
        static public void DisPlayGreeting(
            string firstName, 
            string middleName = default(string),
            string lastName = default(string))
        {
            //....
        }
    }
}
