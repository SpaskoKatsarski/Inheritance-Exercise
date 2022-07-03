using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SportCar mcLaren = new SportCar(460, 300);
            mcLaren.Fuel += 1000;

            Console.WriteLine(mcLaren.Fuel);
            mcLaren.Drive(100);
            Console.WriteLine(mcLaren.Fuel);
        }
    }
}
