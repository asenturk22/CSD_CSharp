namespace _050_Interfaces_cokbicimli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test(new A());
            Test(new B());
            Test(new C());
        }
        public static void Test(IX ix)
        {
            ix.Foo();
        }
    }

    interface IX
    {
        void Foo();
    }

    class A : IX
    {
        public void Foo()
        {
            Console.WriteLine("A.Foo");
        }
    }

    class B : IX
    {
        public void Foo()
        {
            Console.WriteLine("B.Foo");
        }
    }

    class C : IX
    {
        public void Foo()
        {
            Console.WriteLine("C.Foo");
        }
    }


}
