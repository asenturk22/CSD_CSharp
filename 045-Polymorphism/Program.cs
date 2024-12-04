using System.Collections;

namespace _045_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            A a;
            C c = new C();

            a = c;
            a.Foo(0);
            a.Bar(0);
            */

            A a = new A();
            B b = new B();
            C c = new C();

            DoSomething(a);
            DoSomething(b);
            DoSomething(c);

            Console.WriteLine();
            ArrayList al = new ArrayList();

            al.Add(new A());
            al.Add(new B());
            al.Add(new C());
            al.Add(new A());

            foreach (A i in al)
                i.Foo();

        }

        public static void DoSomething(A a)
        {
            a.Foo();
        }
    }

    class A
    {
        public virtual void Foo()
        {
            Console.WriteLine("A.Foo");
        }

        public virtual void Foo(int a)
        {
            Console.WriteLine("A.Foo");
        }
        public void Bar(int a)
        {
            Console.WriteLine("A.Bar");
        }
        //...
    }

    class B : A
    {
        public override void Foo()
        {
            Console.WriteLine("B.Foo");
        }
        public override void Foo(int a)
        {
            Console.WriteLine("B.Foo");
        }
        public new void Bar(int a)
        {
            Console.WriteLine("B.Bar");
        }
        //...
    }

    class C : B
    {
        public override void Foo()
        {
            Console.WriteLine("C.Foo");
        }
        public override void Foo(int a)
        {
            Console.WriteLine("C.Foo");
        }
        public new void Bar(int a)
        {
            Console.WriteLine("C.Bar");
        }
        //...
    }
}
