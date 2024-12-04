namespace _015_checked_unchecked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2000000000, b = 2000000000, c;

            #region unchecked 

            // unchecked da hata fırlatmaz.

            unchecked // yazmasaydık da olurdu default durum 
            {
                c = a + b;      // exception oluşmaz, yüksek anlamlı byte’lar atılır 
            }
            System.Console.WriteLine(c);

            #endregion


            #region  checked 
            // değişkenin içindeki değerin türünün sınırları dışında kalırsa taşma meydan gelir. 
            // checked (Kontrollü bağlam) da exception fırlatır. 


            checked
            {
                c = a + b;      // exception oluşacak! 
            }
            System.Console.WriteLine(c);

            #endregion
        }
    }
}
