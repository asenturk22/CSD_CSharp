namespace _042_boxing_unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object[] objs = new object[] { 1, 2,3,4,5,6,7,8,9};
            int val;

            for (int i = 0; i < objs.Length; i++)
            {
                val = (int)objs[i];
                Console.WriteLine("{0}", val);
            }

            // or 
            Console.WriteLine("");

            foreach (object o in objs)
            {
                val = (int)o;
                Console.WriteLine("{0}", o);
            }
        }
    }
}
