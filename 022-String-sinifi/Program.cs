using System.Runtime.Intrinsics.X86;

namespace _022_String_sinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // public String(char c, int count)

            System.String s = new System.String('a', 5);
            Console.WriteLine(s);

            string s2 = new string('b', 5);
            Console.WriteLine(s2);
            Console.WriteLine(s2.Length); //uzunluğu döner

            string s3;
            Console.WriteLine("Bir yazi giriniz : ");
            s3 = Console.ReadLine();
            for (int i = 0; i < s3.Length; ++i)
            {
                Console.WriteLine(s3[i]);
            }

            Console.WriteLine();

            //ayni yaziyi tersten yazdiralim.
            for (int i = s3.Length - 1; i >= 0 ; --i)
            {
                Console.WriteLine(s3[i]);
            }

            // ToUpper, ToLower
            Console.WriteLine(s3.ToUpper());
            Console.WriteLine(s3.ToLower());



        }
    }
}
