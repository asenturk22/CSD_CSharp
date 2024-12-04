namespace _018_sinif_calismasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sinif calismasi 
            /*
             [0,1] arasında rastgele gerçek sayı üreterek dairenin dörtte birinin alanını 
             karenin alanına bölme yoluyla pi sayısını elde ediniz. 
             */


            System.Random r = new System.Random();

            System.Console.Write("Deneme sayınızı giriniz: ");
            long n = long.Parse(System.Console.ReadLine());
            int quadrentCount = 0;
            double x, y, pi;

            for (int i = 0; i < n; ++i)
            {
                x = (double)r.Next() / System.Int32.MaxValue;
                y = (double)r.Next() / System.Int32.MaxValue;
                if (System.Math.Sqrt(x * x + y * y) < 1) 
                    ++quadrentCount;
            }

            pi = 4D * quadrentCount / n;
            System.Console.WriteLine(pi);
        }
    }
}
