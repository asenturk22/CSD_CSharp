namespace _037_temel_tur_yapilar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------");

            Console.WriteLine("Int32.Minvalue: {0}, Int32.MaxValue: {1}",
                int.MinValue, int.MaxValue);
            Console.WriteLine("------------------------");

            Console.WriteLine("Double.Minvalue: {0}, Double.MaxValue: {1}",
                double.MinValue, double.MaxValue);
            Console.WriteLine("------------------------");

            int a = 1234;
            double b = 12.34;
            string str;
            Console.WriteLine("------------------------");

            str = a.ToString();
            Console.WriteLine(str);
            str = b.ToString();
            Console.WriteLine(str);
            str = 1000.ToString();
            Console.WriteLine(str);
            Console.WriteLine("------------------------");

            a = int.Parse("123");
            Console.WriteLine(a);

            Console.WriteLine("------------------------");

        }
    }
}
