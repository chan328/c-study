using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class Computer
    {

    }

    interface IMonitor
    {
        //void TurnOn();
    }
    interface IKeyboard // 인터페이스는 메서드의 묶음.
    {
       
    }

    // 클래스 상속과 함께 인터페이스로부터 다중 상속이 가능하다.
    class Notebook : Computer, IMonitor, IKeyboard
    {
        //public void TurnOn();
        // 추상 메서드와 달리 override 예약어가 필요 없음.
    }
}
