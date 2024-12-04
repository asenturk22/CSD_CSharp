using System.Collections;

namespace _044_ArrayList_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(13);
            al.Add(21);
            al.Add(2);
            al.Add(9);
            al.Sort();

            foreach (int x in al)
                Console.Write("{0} ", x);

            Console.WriteLine();


            ArrayList s_al = new ArrayList();
            s_al.Add("Zeynep Oruç");
            s_al.Add("Ahmet Altıntartı");
            s_al.Add("Yavuz Aslan");
            s_al.Add("Bünyamin Kılıç");
            s_al.Sort();
            foreach (string name in s_al)
                Console.WriteLine(name);

        }
    }
}
