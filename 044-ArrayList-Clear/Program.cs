using System.Collections;

namespace _044_ArrayList_Clear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            for (int i = 0; i < 10; ++i)
                al.Add(i);
            Console.Write("Elemanlar: {");

            foreach (int x in al)
                Console.Write("{0} ", x);
            Console.WriteLine("}}, Count = {0}, Capacity = {1}", al.Count, al.Capacity);

            al.Clear();

            Console.Write("Elemanlar: {");

            foreach (int x in al)
                Console.Write("{0} ", x);
            Console.WriteLine("}}, Count = {0}, Capacity = {1}", al.Count, al.Capacity);
        }
    }
}
