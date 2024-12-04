namespace _038_UML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               1- Bir sınıf başka bir sınıfı içerebilir.              
             */

            Automobile a = new Automobile();
            //...


            //2- Birleşme ilişkisi 

        }


    }

    class Engine
    {
        //..
    }

    class Automobile
    {
        private Engine m_engine;
        //...

        public Automobile()
        {
            m_engine = new Engine();
            //...
        }
        //..
    }
}
