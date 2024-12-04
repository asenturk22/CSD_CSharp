namespace _031_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] b;        
            
            b = new int[10];

            for (int i = 0; i < 10; i++)
            {
                b[i] = i;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}", b[i]);
            }


            int[] a;
            int n;

            Console.Write("Dizi uzunluğunu giriniz:");
            n = int.Parse(Console.ReadLine());
            a = new int[n];

            for (int i = 0; i < n; ++i)
            {
                Console.Write("{0}.İndeksli elemanı giriniz:", i);
                a[i] = int.Parse(Console.ReadLine());
            }

            int total = 0;
            for (int i = 0; i < n; ++i)
                total += a[i];
            Console.WriteLine("Dizideki elemanların toplamı = {0}", total);

           

        }
    }
}
