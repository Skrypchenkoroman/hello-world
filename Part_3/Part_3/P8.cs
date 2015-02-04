using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Part_3
{
    class Program
    {
        class A
        {
            public virtual void Print()
            {
                Console.WriteLine("A::Print");
            }
        }

        class B : A
        {
            public override void Print()
            {
                Console.WriteLine("B::Print");
            }
        }

        class C : B
        {
            public new void Print()
            {
                base.Print();

                Console.WriteLine("C::Print");
            }
        }

        class Point { public int x; public int y; }
        static void Main(string[] args)
        {
            A a = new A();
            A b = new B();
            A c = new C();
            
            Point p1 = new Point();
            Point p2 = new Point();
            p1.x = 1;
            p1.y = 1;
            p2.x = 2;
            p2.y = 2;
            Console.WriteLine("p1==p2" + (p1 == p2));
            Console.WriteLine("Equals" + p1.Equals(p2));
            p1.x = 2;
            p1.y = 2;
            Console.WriteLine("p1==p2" + (p1 == p2));
            Console.WriteLine("Equals" + p1.Equals(p2));
            p1.x = 1;
            p1.y = 1;
            p2.x = 2;
            p2.y = 2;
            Console.WriteLine("p1==p2" + (p1 == p2));
            Console.WriteLine("Equals" + p1.Equals(p2));
            p1 = p2;
            Console.WriteLine("p1==p2" + (p1 == p2));
            Console.WriteLine("Equals" + p1.Equals(p2));

            a.Print();
            b.Print();
            c.Print();

            string v1 = "Hello, my name is Roman Skrypchenko";
            string v2 = v1;
            string v3 = "01/02/1993";

            // v1 = v1.Replace("a", "HAHA");
            
            v1 = Regex.Replace(v1, "my", "name", RegexOptions.IgnoreCase);
            DateTime dt = DateTime.Parse(v3);
            DateTime dt2 = dt;

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a==b);
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(dt);
            Console.ReadKey();
        }
    } 
}
