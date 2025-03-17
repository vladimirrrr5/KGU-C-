using System;
namespace Name
{
    class Program
    {
        static void Main()
        {
            Robot bot = new Robot();
            bot.name = "Bot";
            bot.weight = 800;
            bot.coordinates = new int[] {0, 0, 0};
            
            System.Console.WriteLine(bot.name + "weight" + bot.weight);
            Robot killer = new Robot();
            killer.weight = 1000;
            killer.name = "Killer";
            bot.coordinates = new int[] {0, 0, 0};
        }
    }
    class Robot
    {
        public string name;
        public int weight;
        public int[] coordinates;

        
    }
}