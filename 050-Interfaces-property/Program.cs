namespace _050_Interfaces_property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            IX ix = s;
            
            ix.Count = 10;
            Console.WriteLine(ix.Count);
        }
    }

    interface IX
    {
        int Count
        {
            get;
            set;
        }
    }

    class Sample : IX
    {
        private int m_count;

        public int Count
        {
            get { return m_count; }
            set { m_count = value; }
        }
    }
}
