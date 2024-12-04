using System;
using System.Threading;


namespace _047_delegates_event_4
{
    internal class Program
    {

        /*
         
        Şimdi belli bir zamana gelindiğinde verilen bir metodu çağıran AlarmClock isimli bir sınıf
        yazmak isteyelim. Bu sınıf bizden bir DateTime alsın o zaman gelince Alarm isimli event 
        delege elemana += operatörü ile yerleştirilen metodu çağırsın:
         
        */

        public static void Main()
        {
            AlarmClock ac = new AlarmClock(DateTime.Now.AddSeconds(20));
            ac.Alarm += new AlarmProc(MyAlarmProc);
            Console.ReadLine();
        }
        public static void MyAlarmProc()
        {
            Console.WriteLine("Alarm çaldı!");
        }

    }

    class AlarmClock
    {
        private DateTime m_alarmTime;
        private Timer m_timer;
        public event AlarmProc Alarm;

        public AlarmClock(DateTime alarmTime)
        {
            m_alarmTime = alarmTime;
            m_timer = new Timer(new TimerCallback(TimerProc), 0, 1, 1000);
        }

        public void TimerProc(object o)
        {
            Alarm();
            m_timer.Dispose();
        }
    }

    delegate void AlarmProc();
}
