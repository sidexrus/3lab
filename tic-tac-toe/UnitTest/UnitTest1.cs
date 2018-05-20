using System;
using System.Collections.Generic;
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
        [TestMethod]
        public void TestMethod2()
        {
            game g = new game();
            bool f = g.x_o;
        }
        [TestMethod]
        public void TestMethod3()
        {
            game g = new game();
            List<int> res = new List<int>();
            g.checkresult(res);
        }
        [TestMethod]
        public void TestMethod4()
        {
            game g = new game();
            List<int> res = new List<int>();
            for (int i = 0; i < 3; i++)
                res.Add(1);
            Assert.AreEqual(1, g.checkresult(res));
        }
        [TestMethod]
        public void TestMethod5()
        {
            game g = new game();
            List<int> res = new List<int>();
            for (int i = 0; i < 10; i++)
                res.Add(0);
            for (int i = 0; i < 10; i+=3)
                res.Add(1);
            Assert.AreEqual(1, g.checkresult(res));
        }
    }
}
