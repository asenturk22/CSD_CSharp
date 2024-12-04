using System.Security.Cryptography.X509Certificates;

namespace _038_inheritance_private
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();

            b.DispA();
            b.DispB();
        }
    }

    class A
    {
        private int m_a;

        public A()
        {
            Console.WriteLine("A default constructor");
            m_a = 10;
        }

        public void DispA()
        {
            Console.WriteLine(m_a);
        }
    }

    class B : A
    {
        private int m_b;

        public B() : base() 
        {
            {
                Console.WriteLine("B default constructor");
                m_b = 20;
            }


        }

        public void DispB()
        {
            Console.WriteLine(m_b);
        }
    }
}
