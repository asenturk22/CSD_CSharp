namespace _004_Optional_parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Foo(10);            //10, 100, 200
            Foo(10, 20);        //10, 20,  200
            Foo(10, 20, 30);    //10, 20,  30

            Foo(c: 10, a: 20, b: 4);   // 20, 4, 10   olacaktir. 

        }

        public static void Foo(int a, int b = 100, int c = 200)
        {
            System.Console.WriteLine("a = {0}, b = {1}, c= {2}", a, b, c);
        }
    }
}
