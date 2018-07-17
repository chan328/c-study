using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    struct DivideResult
    {
        public bool Success;
        public int Result;
    }
    
    public class Out
    {
        DivideResult Divide(int n1, int n2)
        {
            DivideResult ret = new DivideResult();

            if (n2 == 0)
            {
                ret.Success = false;
                return ret;
            }

            ret.Success = true;
            ret.Result = n1 / n2;
            return ret;
        }
        /*
        bool Divide(int n1, int n2, out int result)
        {
            if (n2 == 0)
            {
                result = 0;
                return result;
            }

            return n1 / n2;
            return true;
        }

        int quotient;
        if(Divide(15, 3, out quotient) == true)
            {
                Console.writeLine(quotient);
            }
            */
    }
}
