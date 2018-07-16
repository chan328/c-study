using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
   public class Currency
    {
        decimal money;
        public decimal Money {  get { return money; } }

        public Currency(decimal money)
        {
            this.money = money;
        }
    }

    public class Won : Currency
    {
        public Won(decimal money) : base(money) { }

        public override string ToString()
        {
            return Money + "Won";
        }
    }

    public class Dollar : Currency
    {
        public Dollar (decimal money) : base(money) { }

        public override string ToString()
        {
            return Money + "Yen";
        }
    }
}
