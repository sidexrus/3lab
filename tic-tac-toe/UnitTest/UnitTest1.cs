using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tic_tac_toe;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            game g = new game();
        }
        public void TestMethod2()
        {
            game g = new game();
            bool f = g.x_o;
        }
        public void TestMethod3()
        {
            game g = new game();
            g.checkresult();
        }
    }
}
