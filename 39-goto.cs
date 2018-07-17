using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class Class2
    {
        static void Main(string[] args)
        {
            bool isOut = false;
            bool isFilt = false;

            foreach(string option in args)
            {
                switch (option)
                {
                    case "out":
                        isOut = true;
                        isFilt = false;
                        goto default; // 원하는 곳으로 이동
                    case "\f":
                        isFilt = true;
                        isOut = false;
                        goto default;
                    default:
                        break;
                }
            }
        }
    }
}
