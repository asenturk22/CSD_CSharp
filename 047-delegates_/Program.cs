namespace _047_delegates_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proc d;

            d = Sample.Foo; // d = new Proc(Sample.Foo)
            d();

            d += Sample.Bar; // d += new Proc(Sample.Bar)
            d();
        }
    }

    class Sample
    {
        public static void Foo()
        {
            Console.WriteLine("Sample.Foo");
        }
        public static void Bar()
        {
            Console.WriteLine("Sample.Bar");
        }
    }

    delegate void Proc();
}
