namespace _023_Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string date;
            string day, month, year;

            System.Console.Write("gg/aa/yyyy formatında bir tarih giriniz:");
            date = System.Console.ReadLine();

            day = date.Substring(0, 2);
            month = date.Substring(3, 2);
            year = date.Substring(6, 4);

            System.Console.WriteLine("{0}-{1}-{2}", day, month, year);
        }
    }
}
