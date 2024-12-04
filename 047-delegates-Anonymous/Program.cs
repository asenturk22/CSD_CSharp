namespace _047_delegates_Anonymous
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proc d;
            int result;

            d = delegate (int a) { return a * a; };

            result = d(10);
            Console.WriteLine(result);


            string str = ".";

            Timer timer = new Timer(delegate { Console.WriteLine(str); Foo(); }, null, 0, 1000);
            Console.ReadLine();
        }

        public static void Foo()
        {
            Console.WriteLine(";");
        }
    }

    delegate int Proc(int a);
}
