namespace _038_inheritance_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();

            b.m_x = 1;
            b.m_y = 2;
            b.m_z = 3;
            b.m_k = 4;
            
            Console.WriteLine("{0}, {1}, {2}, {3} ", b.m_x, b.m_y, b.m_k, b.m_z);

        }
    }

    class A
    {
        public int m_x;
        public int m_y;
        // ...
    }

    class B : A
    {
        public int m_z;
        public int m_k;
        // ...
    }

}
