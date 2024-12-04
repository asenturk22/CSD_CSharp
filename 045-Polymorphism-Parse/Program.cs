namespace _045_Polymorphism_Parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "123";
            string k;
            int a;

            k = s + 1;
            Console.WriteLine(k); // 1231

            a = int.Parse(s) + 1;
            Console.WriteLine(a); ; // 124

            int val;
            Console.Write("Bir değer giriniz:");
            val = int.Parse(Console.ReadLine());
            Console.WriteLine(val);


            string s1 = "123";
            int val1;
            val1 = Convert.ToInt32(s1);
            Console.WriteLine(val1); ;
        }
    }
}
