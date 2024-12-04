namespace _047_delegates_event_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventTest et = new EventTest();
            et.E += new Proc(Sample.Foo);
            et.Fire();
        }
    }

    class EventTest
    {
        public event Proc E;
        public void Fire()
        {
            E();
        }
    }

    class Sample
    {
        public static void Foo()
        {
            Console.WriteLine("Foo");
        }
    }
    
    delegate void Proc();
}

