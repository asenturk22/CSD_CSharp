namespace _047_this
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();


            // s.Set(10, 20);
            // s.Disp();

            Sample.Set(s, 10, 20);
            Sample.Disp(s);

            /*
             Sınıfın bir veri elemanıyla aynı isimli bir yerel değişken ya da parametre değişkeni olduğu durumda sınıfın
veri elemanına erişmek için this anahtar sözcüğü kullanılabilir.
             */


        }
    }

    class Sample
    {
        private int m_a;
        private int m_b;

        public static void Set(Sample s, int a, int b)
        {
            s.m_a = a;
            s.m_b = b;
        }
        public static void Disp(Sample s)
        {
            Console.WriteLine("{0}, {1}", s.m_a, s.m_b);
        }
    }

    class Foo
    {
        private int a;
        public Foo(int a)
        {
            this.a = a; // this.a sınıfın veri elemanı olan a
        }
    }
}
