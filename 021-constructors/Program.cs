namespace _021_constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            Sample k = new Sample(5, 4);
        }
    }

    public class Sample
    {
        int a;
        int b;

        public Sample()
        {
            Console.WriteLine("I am a default constructor");
        }

        public Sample(int a, int b)
        {
            Console.WriteLine("I am a int, int parameters constructor");
        }
    }
}
