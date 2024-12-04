namespace _037_enum_turleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ana renkler, 
            // haftanın günleri, 
            // aylar,
            // yönler vs.

            /*
             *          1 
                       / \  
                        |
                4  < ------ >  2
                        |
                       \ / 
                        3

                Yukarıdaki  yöntemi int (1, 2, 3, 4) veya 
                                    string ("up", "down", "right", "left") yerine 
                enum türü daha avantajlıdır. 

                          up 
                         / \  
                          |
                left  < ------ >  right
                          |
                         \ / 
                         down 


                enum türünden bir değişken bildirildiğinde o değişken değerin kendisini tutar, 
                bir adres tutmaz. 
             */

            Direction d;

            d = Direction.Right;
            Console.WriteLine(d);

            d = (Direction)Enum.Parse(typeof(Direction), Console.ReadLine());
            Console.WriteLine(d);

            Move(Direction.Up);
            Move(Direction.Down);

            Fruit f = Fruit.WaterMellon;
            Fruit result;

            result = f + 2;
            Console.WriteLine(result); // Cherry

            Day day = Day.Monday;
            Day _result;
            _result = day + 2;
            Console.WriteLine(_result); // Wednesday

            string[] names;
            names = Enum.GetNames(typeof(Fruit));
            foreach (string name in names)
                Console.WriteLine(name);
        }

        public static void Move(Direction d)
        {
            Console.WriteLine(d);
        }
    }   

    enum Fruit
    {
        Apple, WaterMellon, Banana, Cherry, Strawberry
    }
    
    enum Direction : int   // : int -> yazmasak da aynı anlamdadır. 
    {
        // Up = 0, Right = 1, Down = 2, Left = 3
        Up, Right, Down, Left
    }

    enum Day
    {
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }
}
