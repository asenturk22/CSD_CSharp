namespace _017_Random_yazi_tura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n;
            long head, tail;
            System.Random r;
            int val;


            System.Console.WriteLine("Deney sayisini giriniz :");
            n = int.Parse(System.Console.ReadLine());

            head = tail = 0;
            r = new System.Random();
            for (long i = 0; i < n; ++i)
            {
                val = r.Next(2);
                if (val == 0)
                {
                    ++tail;
                }
                else
                {
                    ++head;
                }
            }

            double headRatio, tailRatio;

            headRatio = (double)head / n;
            tailRatio = (double)tail / n;

            System.Console.WriteLine("Tura oranı = {0}", headRatio);
            System.Console.WriteLine("Yazi oranı = {0}", tailRatio);
        }
    }
}
