namespace _050_050_Interfaces_abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IX ix = new Mample();
            ix.Foo();                   // Sample.Foo çağrılır. 
        }
    }

    interface IX
    {
        void Foo();
    }

    class Sample : IX
    {
        public virtual void Foo() 
        {
            Console.WriteLine("Sample.Foo");
        }
    }

    class Mample : Sample
    {
        public override void Foo()
        {
            Console.WriteLine("Mample.Foo");
        }
    }

}
