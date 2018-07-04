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
            int num1;
            int num2;
            int num3;
            int num4;

            System.Console.Write("Enter the numerator");
            num1 = int.Parse(System.Console.ReadLine());

            System.Console.Write("Enter the denominator");
            num2 = int.Parse(System.Console.ReadLine());

            num3 = num1 / num2;
            num4 = num1 % num2;

            System.Console.WriteLine(
                $"{num1} % {num2} = {num3} +나머지 ==> {num4}"
                );
        }
    }
}
