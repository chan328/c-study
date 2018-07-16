using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    public class Computer
    {
        protected bool powerOn; // 자기 자식에게만 사용가능
        public void Boot() { }
        public void Shutdown() { }
        public void Reset() { }
    }

    public class Notebook : Computer
    {
        // 중략
    }

    sealed class Pen // sealed는 상속을 막음!
    {

    }
    public class ElectricPen : Pen // 컴파일 오류 발생 
    {

    }
}
