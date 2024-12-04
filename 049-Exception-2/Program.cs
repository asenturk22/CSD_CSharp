namespace _049_Exception_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val;

            for(; ; )
            {
                try
                {
                    Console.Write("Bir sayı giriniz: ");
                    val = int.Parse(Console.ReadLine());
                    Console.WriteLine(val);
                    break;
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine("Argüman null değerinde");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Sayının formatı bozuk");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Sayı çok büyük ya da çok küçük");
                }
            }
        }
    }
}
