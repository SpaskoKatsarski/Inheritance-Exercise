using System;

namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Reptile reptile = new Reptile("Gosho");
            Console.WriteLine("Reptile name: " + reptile.Name);

            Bear bear = new Bear("Tsetsa");
            //Console.WriteLine(bear.ToString());
            Console.WriteLine(bear.Name);
        }
    }
}