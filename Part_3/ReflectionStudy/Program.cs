#define Lol
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionStudy
{
    class Z : Attribute
    {
        public string name;
        public Z(string name)
        {
            this.name = name;
        }

    }

    [Z("Hello")]
    class A
    {
        public string a;
    }

    class Program
    {    
        

        static void Main(string[] args)
        {

           // Test1();
           // Test2();
            // Test3();
            // Test4();
            Test5();

            Console.ReadKey();
            
        }

        public static void Test1()
        {
            Type t = typeof(System.String);
            Type t1 = t.GetType();

            Console.WriteLine(t + "   " + t1);
            ConstructorInfo[] ci = t.GetConstructors();
            int i = 1;
            foreach (MemberInfo mi in ci)
            {
                Console.WriteLine("nomer = " + i + " : " + mi);
                i++;
            }

            i = 0;
            PropertyInfo[] mmb = t.GetProperties();
            foreach (MemberInfo miz in mmb)
            {
                i++;
                Console.WriteLine("testtest {0} = {1} / {2}", i, miz, miz.MetadataToken);
            }

            // ===================================================================================
            // ===================================================================================

            Type classtype = typeof(A);
            Type attributetype = typeof(Z);
            Z def = (Z)Attribute.GetCustomAttribute(classtype, attributetype);
            Console.WriteLine("look {0}", def.name);

            // ===================================================================================
            // ===================================================================================

            Console.WriteLine("\nReflection.MemberInfo");
            // Gets the Type and MemberInfo.
            Type MyType = Type.GetType("System.IO.File");
            MemberInfo[] Mymemberinfoarray = MyType.GetMembers();
            // Gets and displays the DeclaringType method.
            Console.WriteLine("\nThere are {0} members in {1}.",
                Mymemberinfoarray.Length, MyType.FullName);
            Console.WriteLine("{0}.", MyType.FullName);
            if (MyType.IsPublic)
            {
                Console.WriteLine("{0} is public.", MyType.FullName);
            }
            // ===================================================================================
            Console.ReadKey();
        }

        // ===================================================================================
        // ===================================================================================
        // ===================================================================================

        public static void Test2()
        {
            #if Lol
                Int32 x = 5;
            Object o = x;
            x++;
                Console.WriteLine("{0} / {1}", x, o); // 6 и 5
#else
            Int32 x = 4;
                Object o = x;
                x++;
                Console.WriteLine("{0} / {1}", x, o); // 6 и 5
#endif
            
        }

        // ===================================================================================
        // ===================================================================================
        // ===================================================================================
        
internal interface IChangeBoxedPoint{ void Change(Int32 x, Int32 y);}
// Point – значимый тип
internal struct Point : IChangeBoxedPoint{
private Int32 m_x, m_y;
public Point(Int32 x, Int32 y){m_x = x; m_y = y;}
public void Change(Int32 x, Int32 y){m_x = x; m_y = y;}
public override String ToString(){
return String.Format("({0},{1})",m_x.ToString(),m_y.ToString()); }
}

        public static void Test3()
        {
            Point p = new Point(1, 1);
            Console.WriteLine(p); // 1,1
            p.Change(2,2);
            Console.WriteLine(p); // 2,2
            Object o = p;
            Console.WriteLine(o); // 2,2
            ((Point)o).Change(3, 3);
            Console.WriteLine(o); // 2,2
            ((IChangeBoxedPoint)p).Change(4, 4);
            Console.WriteLine(p); // 2,2
            ((IChangeBoxedPoint)o).Change(5, 5);
            Console.WriteLine(o); // 5,5
        }

        // ===================================================================================
        // ===================================================================================
        // ===================================================================================
        class ClassTest4 
        {
            public string someField;
            public ClassTest4(string someField)
            {
                this.someField = someField;
            }
            public void Print()
            {
                Console.WriteLine("YOLO");
            }
        }

        public static void Test4()
        {
            ClassTest4 test_by_1 = new ClassTest4("A");
            //ClassTest4 test_by_2 = new ClassTest4("A");
            ClassTest4 test_by_2 = test_by_1;
            Console.WriteLine("{0}, {1}, {2}", (test_by_1==test_by_2), (test_by_1.Equals(test_by_2)), Object.Equals(test_by_1,test_by_2));
            dynamic a = test_by_1;
            a.Print();
        }

        // ===================================================================================
        // ===================================================================================
        // ===================================================================================
        class B
        {
            static B()
            {
                left = 3;
            }
            public const Int32 right = 1;
            public static readonly Int32 left = 2;
            public virtual void Pr() { Console.WriteLine("class b"); }
            
        }
        class C : B
        { public new void Pr() { Console.WriteLine("class c"); } }
        
        public static void Test5()
        {
            B b1 = new B();
            b1.Pr();
            B b2 = new C();
            b2.Pr();
            C c1 = new C();
            c1.Pr();
        }

        // ===================================================================================
        // ===================================================================================
        // ===================================================================================
        public static void HelloWorld()
        {
            Console.WriteLine("Hello");
        }
    }
}
