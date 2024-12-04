using System.Collections;

namespace _051_ICloneable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al1 = new ArrayList();

            for (int i = 0; i < 10; i++)
            {
                al1.Add(i);
            }

            ArrayList al2 = (ArrayList)al1.Clone();
            al2.Add(25);
            al2.Add(45);

            foreach (int x in al2)
                Console.Write("{0} ", x);
            Console.WriteLine();    

            foreach (int x in al1)
                Console.Write("{0} ", x);
            Console.WriteLine();


            Person per1 = new Person("Ahmet Demir", 123);
            Person per2;
            per2 = (Person)per1.Clone();

            Console.WriteLine(per1);
            Console.WriteLine(per2);


            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] b;
            b = (int[])a.Clone();
            foreach (int x in b)
                Console.Write("{0} ", x);
            Console.WriteLine();
        }
    }

    //Biz de ICloneable arayüzünü destekleyen sınıflar yada yapılar oluşturabiliriz. 

    class Person : ICloneable
    {
        private string m_name;
        private int m_no;

        public Person()
        {

        }

        public Person(string name, int no)
        {
            m_name = name;
            m_no = no;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", m_name, m_no);
        }

        public object Clone()
        {
            Person per = new Person();
            per.m_name = m_name;
            per.m_no = m_no;

            return per;
        }
    }
}
