namespace _047_base
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.Bar();
        }
    }

    class A
    {
        public void Foo()
        {
            Console.WriteLine("A.foo");
        }
    }

    class B : A 
    {
        public new void Foo()
        {
            Console.WriteLine("B.Foo");
        }

        public void Bar()
        {
            Console.WriteLine("B.Bar");
            Foo();          // B.Bar çağrılır
            base.Foo();     // A.Foo çağrılır. 
        }
    }
}
