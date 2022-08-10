using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;

namespace MSTest_Tests
{
    [TestClass]
    public class StaticConstructorTests
    {
        [DllImport("mixed mode test library.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern bool initMixedModeDll();


        [TestMethod]
        public void Init_Must_Return_True()
        {
            MixedModeClass.doSomethingWeired = false;
            bool b = initMixedModeDll();
            Assert.IsTrue(b);
        }
    }
}
