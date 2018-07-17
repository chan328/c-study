using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class Computer
    {
        public void TurnOn()
        {
            Console.WriteLine("Computer : TurnOn");
        }
    }

    class Switch
    {
        public void PowerOn(Computer machine) // Computer 타입을 직접 사용한다.
        {
            machine.TurnOn();
        }
    }
    // --------------------------------------------------------------------------------
    // 느슨한 결합
    interface IPower
    {
        void TurnOn();
    }

    class Monitor : IPower
    {
        public void TurnOn()
        {
            Console.WriteLine("Monitor: TurnOn");
        }
    }

    class Switch2
    {
        public void PowerOn(IPower machine) // 특정타입 -> 인터페이스
        {
            machine.TurnOn();
        }
    }
}
