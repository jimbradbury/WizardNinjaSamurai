using System;

namespace WizardNinjaSamurai
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Human hero = new Human("Jim");
            Human badguy = new Human("EvilDude");

            Console.WriteLine("PRE-ATTACK");
            Console.WriteLine("Name of Hero: {0}", hero.name);
            Console.WriteLine("Health of Here: {0}", hero.health);
            Console.WriteLine("Name of BadGuy: {0}", badguy.name);
            Console.WriteLine("Health of BadGuy: {0}", badguy.health);

            hero.Attack(badguy);

            Console.WriteLine("POST-ATTACK");
            Console.WriteLine("Name of Hero: {0}", hero.name);
            Console.WriteLine("Health of Here: {0}", hero.health);
            Console.WriteLine("Name of BadGuy: {0}", badguy.name);
            Console.WriteLine("Health of BadGuy: {0}", badguy.health);

        }
    }
}
