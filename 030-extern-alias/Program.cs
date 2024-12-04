extern alias ACompany;
extern alias BCompany;

namespace _030_extern_alias
{
    
    //extern alias BCompany;
    internal class Program
    {
        static void Main(string[] args)
        {
            ACompany::_030_A.Sample s = new ACompany::_030_A.Sample();
            BCompany::_030_B.Sample k = new BCompany::_030_B.Sample();

            s.Bar();
            k.Foo();
        }
    }
}
