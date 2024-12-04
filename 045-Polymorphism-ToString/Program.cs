using System.Collections;

namespace _045_Polymorphism_ToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            al.Add(new Sample());
            al.Add(new Mample());
            al.Add(new Tample());
            
            foreach (object o in al)
                Console.WriteLine(o.ToString());


            int a = 123;
            double b = 123.52;
            char c = 'a';

            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(c.ToString());

            object[] objs = new object[] { 123, 23.56, new Sample(), DateTime.Today };
            foreach (object o in objs)
            {
                string s = o.ToString();
                Console.WriteLine(s);
            }
        }
    }

    class Sample
    {
        public override string ToString()
        {
            return "This is a Sample";
        }
    }
    class Mample
    {
        public override string ToString()
        {
            return "This is a Mample";
        }
    }
    class Tample
    {
        public override string ToString()
        {
            return "This is a Tample";
        }
    }
}
