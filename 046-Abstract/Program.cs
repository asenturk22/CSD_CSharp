namespace _046_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new B();
            a.Foo(); // B.Foo çağrılır
            a.Bar(); // A.Bar çağrılır
        }
    }
    /*
        - En az 1 abstract eleman varsa sınıfa; abstract sınıf denir. 
        - abstract anahtar sözcüğü ile virtual anahtar sözcüğü  bir arada kullanılamaz. 
        - abstract anahtar sözcüğü virtual anahtar sözcüğünü kapsamaktadır. 
        - bir metot hem abstract hem static olamaz.     
        - Abstract sınıflar; 
            - veri elemanlarına
            - abstract olmayan metotlara
            - static metotlara sahip olabilirler. 
        - Abstract sınıflar türünden referanslar bildirilebilir. 
          Ancak new operatörüyle nesneler yaratılamaz
        - Abstract bir sınıftan türetilen sınıflarda taban abstract sınıfın 
          tüm abstract elemanları override edilmelidird
        
        NOT :  "virtual" metotlar "sen override etmezsen bu çağrılır" anlamına
gelmektedir. Halbuki "abstract" metotlar "sen override etmelisin" anlamına gelir.
     */
    abstract class Shape
    {
        //...
        public abstract void MoveLeft();
        public abstract void MoveRight();
        public abstract void MoveUp();
        public abstract void MoveDown();
        public abstract void Rotate();

    }

    abstract class A
    {
        int m_a;

        public abstract void Foo();
        
        public void Bar()
        {
            Console.WriteLine("A Bar");
        }

    }

    class B : A
    {
        public override void Foo()
        {
            Console.WriteLine("B.Foo");
        }
        //...
    }
}
