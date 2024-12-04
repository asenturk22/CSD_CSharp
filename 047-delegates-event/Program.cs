namespace _047_delegates_event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            s.P = new Proc(Program.Foo);
            s.P();
        }

        public static void Foo()
        {
            Console.WriteLine("Foo");
        }
    }

    /*
     * 
    public event <delege türü> <isim>
    {
        add
        {
            //...
        }
        
        remove
        {
            //...
        }
    }
     
     */
    class Sample
    {
        private Proc m_proc;

        public Proc P
        {
            get { return m_proc; }
            set { m_proc = value; }
        }
    }

    delegate void Proc(); 
}
