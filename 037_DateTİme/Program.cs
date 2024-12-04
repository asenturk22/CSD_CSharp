namespace _037_DateTİme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime(2012, 10, 25);
            Console.WriteLine(dt1.ToString());

            DateTime dt2 = new DateTime(2024, 11, 25, 13, 45, 55);
            Console.WriteLine(dt2.ToString());

            DateTime dt3 = DateTime.Now;
            Console.WriteLine("{0}:{1}:{2}", dt3.Hour, dt3.Minute, dt3.Second);

            // Canlı Saat 
            DateTime dt4;
            DateTime dt5 = DateTime.Now;
            while (!Console.KeyAvailable)
            {
                dt4 = DateTime.Now;
                if (dt4.Second != dt5.Second)
                    Console.Write("{0:D2}:{1:D2}:{2:D2}\r", dt4.Hour, dt4.Minute, dt4.Second);
                dt5 = dt4;
            }

            // Yazısal verilen tarih DateTime türüne dönüştürülmesi
            string s = "12/11/2009 12:11:59";
            DateTime dt = DateTime.Parse(s);
            Console.WriteLine(dt.ToString());

            TimeSpan ts = new TimeSpan(3, 45, 34);
            Console.WriteLine(ts.ToString());

            Console.WriteLine("{0}:{1}:{2}", ts.Hours, ts.Minutes, ts.Seconds);

            Console.WriteLine(ts.TotalDays);
            Console.WriteLine(ts.TotalHours);
            Console.WriteLine(ts.TotalMinutes);
            Console.WriteLine(ts.TotalSeconds);
            Console.WriteLine(ts.TotalMilliseconds);


            TimeSpan ts1 = new TimeSpan(3, 2, 21);
            TimeSpan ts2 = new TimeSpan(2, 59, 51);
            TimeSpan ts3;
            ts3 = ts1 + ts2;
            Console.WriteLine(ts3.ToString());

            DateTime dt_1 = new DateTime(1999, 8, 17, 3, 2, 0);
            DateTime now = DateTime.Now;
            TimeSpan ts_1;
            ts_1 = now - dt_1;
            Console.WriteLine(ts_1.ToString());
            Console.WriteLine(ts_1.TotalMinutes);
        }
    }
}
