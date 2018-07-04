using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class Class1
    {
        static void Main()
        {
            double radius;
            double area;

            System.Console.Write("원의 반지름을 입력하세요.");

            radius = double.Parse(System.Console.ReadLine());
            if (radius >= 0)
            {
                //원의 면적을 계산한다.
                area = 3.14 * radius * radius;
                System.Console.WriteLine(
                    $"원의 넓이 : {area: 0.00}");
            }
            else
            {
                System.Console.WriteLine(
                    $"{radius}는 유효하지 않은 수입니당.");
            }
        }
    }
}
