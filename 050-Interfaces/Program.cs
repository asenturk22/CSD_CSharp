namespace _050_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IX ix = new B();        

            ix.Foo();               // A.Foo çağrılır
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

    class B : A
    {

    }
}
