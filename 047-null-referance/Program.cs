namespace _047_null_referance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = null;

            Sample s = new Sample();
            Console.WriteLine(s.m_name == null ? "null" : s.m_name);
            Console.WriteLine(s.m_no);
        }
    }

    class Sample
    {
        public string m_name;
        public int m_no;
    }
}
