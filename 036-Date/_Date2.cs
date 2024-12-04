using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_Date
{
    /*
            Date date = new Date();

            date.SetDay(10);
            date.SetMonth(12);
            date.SetYear(2012);

            Console.WriteLine("{0}/{1}/{2}", date.GetDay(), date.GetMonth(), date.GetYear());
     */

    public class _Date2
    {
        private string m_date;  //"dd/mm/yyyy"

        public _Date2()
        {
            m_date = "01/01/1900";
        }

        public int GetDay()
        {
            return int.Parse(m_date.Substring(0, 2));
        }

        public void SetDay(int day)
        {
            m_date = m_date.Remove(0, 2).Insert(0, string.Format("{0:D2}", day));
        }

        public int GetMonth()
        {
            return int.Parse(m_date.Substring(3, 2));
        }

        public void SetMonth(int day)
        {
            m_date = m_date.Remove(3, 2).Insert(3, string.Format("{0:D2}", day));
        }

        public int GetYear()
        {
            return int.Parse(m_date.Substring(6, 4));
        }

        public void SetYear(int day)
        {
            m_date = m_date.Remove(6, 4).Insert(6, string.Format("{0:D2}", day));
        }
    }
}
