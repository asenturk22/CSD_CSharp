namespace _035_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // foreach döngüleri IEnumerable arayüzünü destekleyen sınıflarla ve yapılarla kullanılır. 
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int x in a)
                Console.WriteLine(x);

            string[] names = { "ali", "veli", "selami", "ayşe", "fatma" };
            foreach (string name in names)
                Console.WriteLine(name);

            int index;
            foreach (string file in Directory.GetFiles(@"c:\windows"))
            {
                index = file.LastIndexOf('\\');
                Console.WriteLine(file.Substring(index + 1));
            }

            Console.WriteLine("\n");
            int[,] b;
            b = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            foreach (int x in b)
            {
                Console.Write("{0} ", x);
                Console.WriteLine();
            }
            Console.WriteLine();

            foreachJaggedDisp();
        }

        public static void foreachJaggedDisp()
        {
            int[][] a = new int[3][]
             {
             new int[] { 1, 2, 3 },
             new int[] { 4, 5 },
             new int[] { 6, 7, 8, 9 }
             };

            foreach (int[] x in a)
            {
                foreach (int y in x)
                    Console.Write("{0} ", y);
                Console.WriteLine();
            }
        }
    }
}
