using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class A
    {
        private Int32 firstAValue;
        private Int32 secondAValue;
        public A(Int32 firstValue)
        {
            firstAValue = firstValue;
            Console.WriteLine("Class A has been started");
        }
    }
    class B : A
    {
        private Int32 firstBValue;
        public B(Int32 yolo) : base(yolo)
        {
            firstBValue = 3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B(1);
            Console.ReadKey();
        }
    }
}
