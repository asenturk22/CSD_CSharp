namespace _050_Interfaces_reimplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IX ix = new Mample(); // Sample IX'i desteklediği için Mample da destekliyor
            ix.Foo(); // Mample.Foo çağrılır
        }
    }

    interface IX
    {
        void Foo();
    }

    class Sample : IX
    {
        public void Foo()
        {
            Console.WriteLine("Sample.Foo");
        }
        //...
    }
    class Mample : Sample, IX
    {
        public new void Foo()
        {
            Console.WriteLine("Mample.Foo");
        }
        //...
    }
}
