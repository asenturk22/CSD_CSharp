namespace _033_cok_boyutlu_diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a;

            a = new int[3, 4];

            for (int i = 0; i < 3; ++i)
                for (int j = 0; j < 4; ++j) 
                    a[i, j] = i + j;

            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 4; ++j)
                    Console.Write("{0} ", a[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine("{0}X{1}", a.GetLength(0), a.GetLength(1));
            Console.WriteLine(a.Rank);
            Console.WriteLine(a.Length);
        }
    }
}
