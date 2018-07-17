using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    public class Scheduler
    {
        readonly int second = 1;
        readonly string name;

        public Scheduler()
        {
            this.name = "일정관리"; // 읽기 전용 필드는 생성자에서도 대입 가능
        }

        public void Run()
        {
            this.second = 5; // 컴파일 오류 발생함. 일반 메서드에서 값 대입 불가능.
        }
    }
}
