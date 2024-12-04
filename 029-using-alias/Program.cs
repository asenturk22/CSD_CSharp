using Con = System.Console;

namespace _029_using_alias
{
    using ASmp = A.Sample;
    using BSmp = B.Sample;

    internal class Program
    {
        static void Main(string[] args)
        {
            Con.WriteLine("Hello, World!");

            //isim çakımasını önlemek için de kullanılır. 
            ASmp s = new ASmp();
            BSmp k = new BSmp();
        }
    }


}

namespace A
{
    class Sample
    {
        //...
    }
}

namespace B
{
    class Sample
    {
        //...
    }
}
