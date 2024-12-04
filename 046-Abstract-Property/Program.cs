namespace _046_Abstract_Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new B();
            a.Val = 10; // B.Val çalıştırılır
            Console.WriteLine(a.Val); // B.Val çalıştırılır

        }
    }

    abstract class A
    {
        private int m_a;

        public abstract int Val
        {
            get;
            set;
        }
    }

    class B : A
    {
        private int m_b;
        public override int Val
        {
            get { return m_b; }
            set { m_b = value; }
        }
        //..
    }
}
