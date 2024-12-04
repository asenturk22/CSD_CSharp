namespace _038_UML_Aggregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mouse mouse = new Mouse();
            //...

            Computer myComputer = new Computer();
            myComputer.Mouse = mouse;
            //..

            myComputer.Mouse = null;
            Computer yourComputer = new Computer();
            yourComputer.Mouse = mouse;
            //...


        }
    }

    class Mouse
    {
        // ...
    }

    class Computer
    {
        private Mouse m_mouse;
        // ...

        public Computer()
        {
            // ...
        }

        public Mouse Mouse { get => m_mouse; set => m_mouse = value; }
    }
}
