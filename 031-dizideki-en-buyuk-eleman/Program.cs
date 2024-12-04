namespace _031_dizideki_en_buyuk_eleman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            int max;

            a = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            max = a[0];
            for (int i = 0; i < 10; ++i)
                if (max < a[i])
                    max = a[i];

            Console.WriteLine("Max = {0}", max);

            

        }
    }
}
