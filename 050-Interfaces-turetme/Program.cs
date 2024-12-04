namespace _050_Interfaces_turetme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IX ix;
            IY iy;

            Sample s = new Sample();
            
            iy = s;
            ix = iy;
            
            iy.Foo();
            iy.Bar();
            ix.Foo();
        }
    }

    interface IX
    {
        void Foo();
    }

    interface IY : IX
    {
        void Bar();
    }

    class Sample : IY
    {
        public void Bar()
        {
            Console.WriteLine("Sample.Bar");
        }

        public void Foo()
        {
            Console.WriteLine("Sample.Foo");
        }
    }
}
