namespace _049_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // try, catch, throw, finally
            //SubString metodu limit dışına
            // çıkıldığında ArgumentOutOfRangeException isimli bir sınıfla throw eder:

            string s;

            Console.Write("Bir yazı giriniz:");
            s = Console.ReadLine();

            try
            {
                s = s.Substring(3, 7);
                Console.WriteLine(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception oluştu: Yazının ilgili kısmı elde edilemez!..");
            }

            Console.WriteLine("main bitti");
        }
    }
}
