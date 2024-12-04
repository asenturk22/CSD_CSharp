using System.Reflection.Metadata.Ecma335;

namespace _045_Polymorphism_Parser_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileSource fs = new FileSource();
            StringSource ss = new StringSource();

            Parser parser = new Parser(fs);
            parser.DoParse();

            Parser parser2 = new Parser(ss);
            parser2.DoParse();
        }
    }

    class Source
    {
        public virtual char GetChar()
        {
            return ' ';
        }
    }

    class FileSource : Source
    {
        public override char GetChar()
        {
            return 'f';
        }
    }

    class StringSource : Source
    {
        public override char GetChar()
        {
            return 's';
        }
    }

    class NetworkSource : Source
    {
        public override char GetChar()
        {
            return 'n';
        }
        //...
    }

    class Parser : Source
    {
        private Source m_source;

        public  Parser(Source source)
        {
            m_source = source;
        }

        public void DoParse()
        {
            char ch;

            //...
            ch = m_source.GetChar();
            Console.WriteLine(ch);
            //...
            ch = m_source.GetChar();
            Console.WriteLine(ch);
            //...
            ch = m_source.GetChar();
            Console.WriteLine(ch);
            //...
        }
    }


}
