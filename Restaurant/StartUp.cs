using System;

namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Cake cake = new Cake("Torta");
            Console.WriteLine(cake.Price);

            Coffee starBucks = new Coffee("Capuccino", 12.5);
            Console.WriteLine(starBucks.Price); ;
        }
    }
}