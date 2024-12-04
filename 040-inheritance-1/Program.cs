namespace _040_inheritance_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            C c = new C(10, 20, 30);
            B b;
            A a;

            Console.WriteLine("{0}, {1}, {2}", c.ValA, c.ValB, c.ValC); // 10, 20, 30

            b = c;
            Console.WriteLine("{0}, {1}", b.ValA, b.ValB); // 10, 20
            
            a = b;
            Console.WriteLine("{0}", a.ValA); // 10
        }
    }

    class A
    {
        private int m_valA;

        public A(int a)
        {
            m_valA = a;
        }

        public int ValA
        {
            get { return m_valA; }
            set { m_valA = value; }
        }
    }

    class B : A
    {
        private int m_valB;
        public B(int a, int b) : base(a)
        {
            m_valB = b;
        }
        public int ValB
        {
            get { return m_valB; }
            set { m_valB = value; }
        }
        //...
    }

    class C : B
    {
        private int m_valC;
        public C(int a, int b, int c) : base(a, b)
        {
            m_valC = c;
        }
        public int ValC
        {
            get { return m_valC; }
            set { m_valC = value; }
        }
        //...
    }
}
