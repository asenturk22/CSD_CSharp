namespace _038_inheritance_this
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine(a.Val);
        }
    }

    public class A
    {
        private int m_val; 

        public A() : this(10)
        {
            Console.WriteLine("A default constructor");
        }

        public A(int a)
        {
            Console.WriteLine("A int constructor");
            m_val = a; 
        }

        public int Val
        {
            get { return m_val; }
            set { m_val = value; }
        }
    }
}
