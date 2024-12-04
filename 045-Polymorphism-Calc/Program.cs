namespace _045_Polymorphism_Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plus plus = new Plus();
            Multiply mul = new Multiply();
            Divide div = new Divide();
            Minus minus = new Minus();

            Test(plus, 10, 2);
            Test(mul, 10, 2);
            Test(div, 10, 2);
            Test(minus, 10, 2);
        }

        public static void Test(Operator op, double a, double b)
        {
            double result;
            result = op.Calc(a, b);
            Console.WriteLine(result);
        }
    }

    class Operator
    {
        public virtual double Calc(double a, double b)
        {
            return 0;
        }
    }

    class Plus : Operator
    {
        public override double Calc(double a, double b)
        {
            return a + b;
        }
    }

    class Minus : Operator
    {
        public override double Calc(double a, double b)
        {
            return a - b;
        }
        //...
    }

    class Multiply : Operator
    {
        public override double Calc(double a, double b)
        {
            return a * b;
        }
        //...
    }

    class Divide : Operator
    {
        public override double Calc(double a, double b)
        {
            return a / b;
        }
        //...
    }
}
