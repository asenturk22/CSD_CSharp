namespace _045_Polymorphism_top_oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NormalTop nt = new NormalTop();
            ZıplayanTop zt = new ZıplayanTop();
            PatlakTop pt = new PatlakTop();

            Test(nt);
            Test(zt);
            Test(pt);
        }

        public static void Test(Top top)
        {
            top.Git();
            //...
            top.Git();
            //...
            top.Git();
            //...
        }
    }

    public class Top
    {
        public virtual void Git()
        {
            Console.WriteLine("Top gidiyor...");
        }
    }

    public class NormalTop : Top
    {
        public override void Git()
        {
            Console.WriteLine("Top normal gidiyor...");
        }
    }

    public class PatlakTop : Top
    {
        public override void Git()
        {
            Console.WriteLine("Patlak top gidiyor...");
        }
    }

    public class ZıplayanTop : Top
    {
        public override void Git()
        {
            Console.WriteLine("Top zıplayarak gidiyor...");
        }
    }
}
