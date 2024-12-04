using System.Collections;

namespace _044_ArrayList_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            for (int i = 0; i < 10; ++i)
                al.Add(i);

            foreach (int x in al)
                Console.Write("{0} ", x);
            Console.WriteLine();

            al.Reverse();

            foreach (int x in al)
                Console.Write("{0} ", x);
            Console.WriteLine();
        }
    }
}
