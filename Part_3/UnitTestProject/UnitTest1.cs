using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    interface IControl
    {
        void Paint();
    }
    interface IForm
    {
        void Paint();
    }

    [TestClass]
    class Page : IControl, IForm
    {   
        public void Paint() { }
        static void Main2(string[] args)
        {
            Page pp = new Page();
            pp.Paint();

            Console.ReadKey();
        }
    } 

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
