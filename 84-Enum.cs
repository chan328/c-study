using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    [Flags] // enum 타입을 정의할 때 [Flags]라는 특성을 지정함.
    enum Days // enum은 내부에 정의된 식별자 순서에 따라 각각 0부터 시작해 1씩 값을 증가시키며 대응시킨다.
    {
        Sunday = 1, Monday = 2, Tuesday = 4, Wednesday = 8, Thursday = 16, Friday = 32, Saturday = 64
    }
    class Class1
    {
        static void Main(string[] args)
        {
            Days workingDays = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday | Days.Friday | Days.Saturday | Days.Sunday;

            Console.WriteLine(workingDays.HasFlag(Days.Sunday)); // sunday를 포함하고 있는가?

            Days today = Days.Friday;
            Console.WriteLine(workingDays.HasFlag(today));

            Console.WriteLine(workingDays);
        }
    }
}
