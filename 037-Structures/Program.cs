namespace _037_Structures
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Yapılar (Structures)
            Point pt;

            pt = new Point(10, 20);
            Console.WriteLine("({0}, {1})", pt.X, pt.Y);

            pt = new Point();
            Console.WriteLine("({0}, {1})", pt.X, pt.Y);

            Graphics.DrawLine(new Point(10, 20), new Point(30, 40));
            //...
        }
    }

    class Graphics
    {
        public static void DrawLine(Point pt1, Point pt2)
        {
            pt1.Disp();
            pt2.Disp();
        }
    }

    struct Point
    {
        // Yapılar, bir değişken tanımlandiğinda sınıflar gibi adres tutmazlar. 
        // bildirilen değişkenin kendisni tutarlar.  Yapı değişkeni bileşik nesnelerdir. 
        // Yapı nesneleri için new ile tahsisat yapmaya gerek yoktur. 
        public int m_x;
        public int m_y;

        public Point(int x, int y)
        {
            m_x = x;
            m_y = y;
        }

        public int X
        {
            get { return m_x; }
            set { m_x = value; }
        }

        public int Y
        {
            get { return m_y; }
            set { m_y = value; }
        }

        public void Disp()
        {
            Console.WriteLine("X = {0}, Y = {1}", m_x, m_y);
        }
    }


}
