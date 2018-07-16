using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    public class Computer
    {
        bool powerOn;
        public void Boot() { }
        public void Shutdown() { }
        public void Reset() { }
    }

    public class Notebook : Computer
    {
        bool fingerScan;
        public bool HasFingerScanDevice() { return fingerScan; }
    }

    public class Desktop : Computer
    {

    }
    public class Netbook : Computer
    {

    }
}
