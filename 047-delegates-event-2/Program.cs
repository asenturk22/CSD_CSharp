namespace _047_delegates_event_2
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
        private Proc m_e;

        public event Proc E
        {
            add
            {
                m_e = m_e + value; // m_e += value;
            }

            remove
            {
                m_e = m_e - value; // m_e -= value;
            }
        }
        public void Fire()
        {
            m_e();
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
}
