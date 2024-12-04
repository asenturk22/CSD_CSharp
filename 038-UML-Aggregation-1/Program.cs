using System.Drawing;

namespace _038_UML_Aggregation_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    enum FigureType
    {
        King, Queen, Rook, Bishop, Knight, Pawn
    }

    enum Color
    {
        White, Black
    }

    class Figure
    {
        private FigureType m_figureType;
        private Color m_color;

        public Figure(FigureType figureType, Color color)
        {
            m_figureType = figureType;
            m_color = color;
        }

        public FigureType FigureType
        {
            get { return m_figureType; }
            set { m_figureType = value; }
        }

        public Color Color
        { 
            get { return m_color; } 
            set { m_color = value; } 
        }


    }

    class Square
    {
        private Figure m_figure;
        // ...

        public Square()
        {
            // ...
        }

        public Figure Figure
        { 
            get { return m_figure; }
            set { m_figure = value; }
        }

    }

    class Board
    {
        private Square[,] m_squares; 
        // ...


        public Board()
        {
            m_squares = new Square[8, 8];

            for (int i = 0; i < 8; i++)
                for (int k = 0; k < 8; k++)
                    m_squares[i, k] = new Square();

            // Taşlar yerleştiriliyor. 
            m_squares[0, 0].Figure = new Figure(FigureType.Rook, Color.White);
            m_squares[0, 1].Figure = new Figure(FigureType.Knight, Color.White);
            // ....
        }
        // ....

    }
}
