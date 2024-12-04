namespace _041_inheritance_GetType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A x;
            B y = new B();
            C z = new C();

            y = z;
            x = y;

            Console.WriteLine("{0}, {1}, {2}", x.GetType().Name, y.GetType().Name, z.GetType().Name);

            /*
             Mademki her şey object sınıfından türetilmiştir. O halde biz object türünden bir referans dizisine farklı
türlerden nesnelerin referanslarını yerleştirebiliriz. Örneğin:
             
             */
            object[] objs;
            objs = new object[] { "Ankara", new A(), new B(), new C(), new Random() };
            foreach (object o in objs)
                Console.WriteLine(o.GetType().Name);
        }
    }

    class A
    {
        //..
    }

    class B : A
    {
        //..
    }

    class C : B
    {
        //..
    }


}
