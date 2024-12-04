namespace _031_prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] primes;

            primes = Prime.GetPrimes(10);
            for (int i = 0; i < primes.Length; i++)
            {
                Console.WriteLine(i + ": " + primes[i]);
            }
        }
    }

    class Prime
    {
        public static int[] GetPrimes(int n)
        {
            int[]a = new int[n];
            int count = 0;

            for (int i = 2; count < n; i++)
            {
                if (IsPrime(i))
                    a[count++] = i;
            }


            return a;
        }

        public static bool IsPrime(int val)
        {
            if (val < 0) return false;

            if (val % 2 == 0) return val == 2;

            for (int i = 3; i * i <= val; i += 2)
            {
                if (val % i == 0) return false;
            }

            return true;
        }
    }
}
