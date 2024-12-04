using _045_Polymorphism_Tetris;
using System;

namespace _045_Polymorphism_Tetris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tetris tetris = new Tetris();
            tetris.Run();
        }
    }

    class Shape
    {
        public virtual void MoveDown()
        { }
        public virtual void MoveLeft()
        { }
        public virtual void MoveRight()
        { }
        public virtual void Rotate()
        { }
    }

    class BarShape : Shape
    {
        public override void MoveDown()
        {
            Console.WriteLine("BarShape.MoveDown");
        }
        public override void MoveLeft()
        {
            Console.WriteLine("<<BarShape.MoveLeft>>");
        }
        public override void MoveRight()
        {
            Console.WriteLine("<<BarShape.MoveRight>>");
        }
        public override void Rotate()
        {
            Console.WriteLine("<<BarShape.Rotate>>");
        }
    }

    class ZShape : Shape
    {
        public override void MoveDown()
        {
            Console.WriteLine("ZShape.MoveDown");
        }
        public override void MoveLeft()
        {
            Console.WriteLine("<<ZShape.MoveLeft>>");
        }
        public override void MoveRight()
        {
            Console.WriteLine("<<ZShape.MoveRight>>");
        }
        public override void Rotate()
        {
            Console.WriteLine("<<ZShape.Rotate>>");
        }
    }

    class TShape : Shape
    {
        public override void MoveDown()
        {
            Console.WriteLine("TShape.MoveDown");
        }
        public override void MoveLeft()
        {
            Console.WriteLine("<<TShape.MoveLeft>>");
        }
        public override void MoveRight()
        {
            Console.WriteLine("<<TShape.MoveRight>>");
        }
        public override void Rotate()
        {
            Console.WriteLine("<<TShape.Rotate>>");
        }
    }
    class LShape : Shape
    {
        public override void MoveDown()
        {
            Console.WriteLine("LShape.MoveDown");
        }
        public override void MoveLeft()
        {
            Console.WriteLine("<<LShape.MoveLeft>>");
        }
        public override void MoveRight()
        {
            Console.WriteLine("<<LShape.MoveRight>>");
        }
        public override void Rotate()
        {
            Console.WriteLine("<<LShape.Rotate>>");
        }
    }
    class SquareShape : Shape
    {
        public override void MoveDown()
        {
            Console.WriteLine("SquareShape.MoveDown");
        }
        public override void MoveLeft()
        {
            Console.WriteLine("<<SquareShape.MoveLeft>>");
        }
        public override void MoveRight()
        {
            Console.WriteLine("<<SquareShape.MoveRight>>");
        }
        public override void Rotate()
        {
            Console.WriteLine("<<SquareShape.Rotate>>");
        }
    }
}
class Tetris
{
    private Random m_rand;

    public Tetris()
    {
        m_rand = new Random();
    }

    public void Run()
    {
        Shape shape;
        for (; ; )
        {
            shape = GetRandomShape();
            for (int i = 0; i < 30; ++i)
            {
                shape.MoveDown();
                System.Threading.Thread.Sleep(300);
                if (Console.KeyAvailable)
                {
                    switch (Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.LeftArrow:
                            shape.MoveLeft();
                            break;
                        case ConsoleKey.RightArrow:
                            shape.MoveRight();
                            break;
                        case ConsoleKey.Enter:
                            shape.Rotate();
                            break;
                        case ConsoleKey.Q:
                            goto EXIT;
                    }
                }
            }
        }
    EXIT:
        ;
    }

    private Shape GetRandomShape()
    {
        Shape shape = null;

        switch (m_rand.Next(5))
        {
            case 0:
                shape = new BarShape();
                break;
            case 1:
                shape = new SquareShape();
                break;
            case 2:
                shape = new TShape();
                break;
            case 3:
                shape = new LShape();
                break;
            case 4:
                shape = new ZShape();
                break;
        }
        return shape;
    }
}