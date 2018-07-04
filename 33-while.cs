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
            decimal current;
            decimal previous;
            decimal temp;
            decimal input;

            System.Console.Write("양수 integer를 입력하세요");

            input = decimal.Parse(System.Console.ReadLine());
            //decimal.parse는 readline을 10진수를 바꿔줌!
            current = previous = 1;

            while(current <= input)
            {
                temp = current;
                current = previous + current;
                previous = temp;
            }

            System.Console.WriteLine(
                $"피보나치 수는 {current}입니당."
                );
        }
    }
}
