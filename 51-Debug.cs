using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source.boj
{
    class Class2
    {
        static int Main()
        {
            string firstname;
            string ageText;
            int age;
            int result = 0;

            Console.Write("성씨를 입력하세요: ");
            firstname = System.Console.ReadLine();

            Console.Write("나이를 입력하세요: ");
            ageText = System.Console.ReadLine();

            try // 잠재적으로 예외를 가질 수 있는 코드를 try 블록으로 감싼다.
            {
                age = int.Parse(ageText);
                Console.WriteLine(
                    $"안녕 {firstname}씨, 자네 나이는 {age}구나!");
            }
            catch(FormatException) // 그 후 catch를 통해 예외를 가지는 코드의 해결책을 찾음.
            {
                Console.WriteLine(
                    $"나이가 입력되었습니다. {ageText}, 는 유효하지 않습니다.");
            }
            catch(Exception exception)
            {
                Console.WriteLine(
                    $"예상치 못한 오류가 발생했습니다. {exception.Message}");
                result = 1;
            }
            finally
            {
                Console.WriteLine($"잘가요 {firstname}씨");
            }

            return result;
        }
    }
}
