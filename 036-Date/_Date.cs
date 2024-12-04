using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_Date
{
    class _Date
    {
        private int m_day;
        private int m_month;
        private int m_year;

        /*
        public Date(int day, int month, int year)
        {
            m_day = day;
            m_month = month;
            m_year = year;
        }
        */

        public int GetDay()
        {
            return m_day;
        }

        public void SetDay(int day)
        {
            m_day = day;
        }

        public int GetMonth()
        {
            return m_month;
        }

        public void SetMonth(int month)
        {
            m_month = month;
        }

        public int GetYear()
        {
            return m_year;
        }

        public void SetYear(int year)
        {
            m_year = year;
        }

        public void Disp()
        {
            Console.WriteLine("{0}/{1}/{2}", m_day, m_month, m_year);
        }
    }
}
