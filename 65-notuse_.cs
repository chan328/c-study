﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    public class class1
    {
        bool powerOn;
        public void Boot() { }
        public void Shutdown() { }
        public void Rest() { }

        bool fingerScan;
        public bool HasFingerScanDevice()
        {
            return fingerScan;
        }
    }
    public class Desktop
    {
        bool powerOn;
        public void Boot() { }
        public void Shutdown() { }
        public void Reset() { }
    }

    public class Netbook
    {
        bool powerOn;
        public void Boot() { }
        public void Shutdown() { }
        public void Rest() { }
    }
}
