using System.Runtime.InteropServices;
using Xunit;

namespace Xunit_Tests
{
    public class StaticConstructorTests
    {
        [DllImport("mixed mode test library.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void switchOffWeirdness();

        [DllImport("mixed mode test library.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern bool initMixedModeDll();


        [Fact]
        public void Init_Must_Return_True()
        {
            MixedModeClass.doSomethingWeired = false;
            bool b = initMixedModeDll();
            Assert.True(b); 
        }

        //[Fact]
        //public void Init_Must_Return_True_When_Weirdness_Is_SwitchedOff()
        //{
        //    switchOffWeirdness();
        //    bool b = initMixedModeDll();
        //    Assert.True(b);
        //}
    }
}