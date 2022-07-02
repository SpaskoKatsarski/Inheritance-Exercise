using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            BladeKnight bk = new BladeKnight("Stephen", 12);
            Console.WriteLine(bk);
        }
    }
}