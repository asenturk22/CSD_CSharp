namespace _038_inheritance_base
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B b1 = new B();
            B b2 = new B(100, 200);
            Console.WriteLine("m_a = {0}, m_b = {1}", b1.ValA, b1.ValB);
            Console.WriteLine("m_a = {0}, m_b = {1}", b2.ValA, b2.ValB);
        }
    }

    class A
    {
        private int m_a;

        //constructor
        public A() 
        {
            Console.WriteLine("A default constructor");
            m_a = 10;
        }

        public A(int a)
        {
            Console.WriteLine("A int constructor");
            m_a = a; 
        }

        public int ValA
        {
            get { return m_a; }
        }
    }

    class B : A
    {
        private int m_b;
        public B()
        {
            Console.WriteLine("B default constructor");
            m_b = 20;
        }

        public B(int a, int b) : base(a)
        {
            Console.WriteLine("B int, int constructor");
            m_b = b;
        }

        public int ValB
        {
            get { return m_b;  }
        }
    }
}
