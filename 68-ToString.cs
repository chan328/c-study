using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.ToString()); // tostring을 사용하면 해당 인스턴스가 속한 전체 이름을 반환한다.
        }
    }
}
