﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ETMTest.ETMTCPTest test = new ETMTest.ETMTCPTest();
            test.startup();
            test.TCPConnectionTest();
            test.Cleanup();
        }
    }
}
