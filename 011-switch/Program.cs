namespace _011_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day, month, year;

            System.Console.Write("Gün:");
            day = int.Parse(System.Console.ReadLine());

            System.Console.Write("Ay:");
            month = int.Parse(System.Console.ReadLine());

            System.Console.Write("Yıl:");
            year = int.Parse(System.Console.ReadLine());

            Date.DispDate(day, month, year);


        }   
    }

    public class Date
    {
        public static void DispDate(int day, int month, int year)
        {
            string m = "";

            switch (month)
            {
                case 1:  m = "Ocak";   break;
                case 2:  m = "Şubat";   break;
                case 3:  m = "Mart";   break;
                case 4:  m = "Nisan";   break;
                case 5:  m = "Mayıs";   break;
                case 6:  m = "Haziran";   break;
                case 7:  m = "Temmuz";   break;
                case 8:  m = "Ağustos";   break;
                case 9:  m = "Eylül"; break;
                case 10: m = "Ekim"; break;
                case 11: m = "Kasım"; break;
                case 12: m = "Aralık"; break;

                default:
                    System.Console.WriteLine("ay yanlış girilmiş");
                    break;
            }

            System.Console.WriteLine("{0}-{1}-{2}", day, m, year);

        }
         


    }
}
