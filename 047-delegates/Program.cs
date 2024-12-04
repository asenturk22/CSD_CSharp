namespace _047_delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proc d;
            int result;

            d = new Proc(Sample.Add);   //Sample.Add static fonksiyonun adresini geç 
            result = d(10, 20);         //Sample.Add fonksiyonuna 10 ve 20 değerlerini gir işlemi yaptır sonucu result değişkenine aktar
            Console.WriteLine(result);


            d = new Proc(Sample.Multiply);
            result = d(10, 20);
            Console.WriteLine(result);

            //delegates fonksiyona parametre olarak geçebilir. 
            Method x = new Method(Sample.Foo);
            Method y = new Method(Sample.Bar);
            Method z = new Method(Sample.Tar);

            DoSomething(x);
            DoSomething(y);
            DoSomething(z);


            Test(new _Proc(MyMath.Add), 10, 20);
            Test(new _Proc(MyMath.Sub), 10, 20);
            Test(new _Proc(MyMath.Mul), 10, 20);
            Test(new _Proc(MyMath.Div), 10, 20);


        }

        public static void Test(_Proc d, double a, double b)
        {
            double result;
            result = d(a, b);
            Console.WriteLine(result);
        }

        public static void DoSomething(Method d)
        {
            d();
        }
    }


    class Sample
    {
        public static void Foo()
        {
            Console.WriteLine("Sample.Foo");
        }

        public static void Bar()
        {
            Console.WriteLine("Bar");
        }
        public static void Tar()
        {
            Console.WriteLine("Tar");
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    class MyMath
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Sub(double a, double b)
        {
            return a - b;
        }
        public static double Mul(double a, double b)
        {
            return a * b;
        }
        public static double Div(double a, double b)
        {
            return a / b;
        }
    }

    delegate double _Proc(double a, double b);
    delegate int Proc(int a, int b);
    delegate void Method();
}
