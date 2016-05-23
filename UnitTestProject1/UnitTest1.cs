using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1Karl;
using System.IO;
using System.Text;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 1;
            int b = 1;
            int valid = a + b;
            Assert.AreEqual(ConsoleApplication1Karl.Program.add(a, b), valid);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string path = @"C:\Users\karlh\Documents\Visual Studio 2015\Projects\ConsoleApplication1Karl\TestLog.txt";
            File.AppendAllText(path, DateTime.Now.ToShortTimeString() + Environment.NewLine);

            Assert.AreEqual(true, true);
        }
    }
}
