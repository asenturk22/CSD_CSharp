namespace _017_RandomClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rastgele sayı üretmek için
            // System.Random.Next()
            // System.Random.Next(int maxValue)
            // System.Random.Next(int minValue, int maxValue)

            System.Random r = new Random();
            int val;

            for (int i = 0; i < 10; ++i)
            {
                val = r.Next();                     //0,  +2147483647
                System.Console.WriteLine(val);      
                val = r.Next(100);                  //0,  +100
                System.Console.WriteLine(val);
                val = r.Next(100, 500);             //100, +500
                System.Console.WriteLine(val);
            }

        }
    }
}
