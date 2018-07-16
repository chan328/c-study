using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class Mammal
    {
        virtual public void Move()
        {
            Console.WriteLine("움직인다.");
        }
    }
    class Lion : Mammal
    {
        public override void Move()
        {
            Console.WriteLine("네 발로 움직인다.");
        }
    }
    class Whale : Mammal
    {
        public override void Move()
        {
            Console.WriteLine("수영한다.");
        }
    }
    class Human : Mammal
    {
        public override void Move()
        {
            Console.WriteLine("두 발로 움직인다.");
        }
    }
}
