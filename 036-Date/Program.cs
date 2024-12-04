namespace _036_Date
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date();

            date.Day = 10;
            date.Month = 12;
            date.Year = 2024;

            Console.WriteLine("{0}/{1}/{2}", date.Day, date.Month, date.Year);

            ++date.Day;   //Bu işlemin eşdeğeri date.Day = date.Day + 1;   //önce get methodu, sonra set methodu
            Console.WriteLine("{0}/{1}/{2}", date.Day, date.Month, date.Year);

            date.Month -= 4;
            Console.WriteLine("{0}/{1}/{2}", date.Day, date.Month, date.Year);

        }
    }


    class Date
    {
        private int m_day;
        private int m_month;
        private int m_year;


        // Getter and Setter Property
        public int Day
        {
            get { return m_day; }
            set { m_day = value; }
        }

        public int Month
        {
            get { return m_month; }
            set { m_month = value; }
        }

        public int Year
        {
            get { return m_year; }
            set { m_year = value; }
        }

        // Aynı sınıfı aşağıdaki gibi de yazabiliriz. 
    }
}
