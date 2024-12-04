namespace _036_siniflarda_erisim_belirleyicileri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Siniflarin elemanlari beş erişim belirleyicisinden birine sahip olabilirler. 
            // 1- public
            // 2- protected
            // 3- private
            // 4- internal
            // 5- protected internal


        }
    }

    class Sample
    {
        private int m_maxCounmt = 0;

        public void DoSomethingImportant()
        {
            //...
            Foo();

            Bar();
            //...

            Tar();
            //...
        }

        private void Foo()
        {
            //...
        }

        private void Bar()
        {
            //...
        }
        
        private void Tar()
        {

        }
    }
}
