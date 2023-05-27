using System;

namespace swordsandsandals
{
    public class Menu
    {
        ConsoleKeyInfo chinput; // Stores user input key

        public Menu(Character MyCharacter, Arena MainArena, Enemy LastFightWith, Enemy PenultimateFightWith)
        {
            Console.WriteLine("Press 1 to fight with the boss\nPress 2 to fight with the cipher\nPress 0 to leave the game.\nPress any key to upgrade your statistics.");
            chinput = Console.ReadKey(); // Read user input

            switch (chinput.Key) // Determine user's choice (fight, upgrade stats, or exit)
            {
                case ConsoleKey.D1: // Fight with boss
                    new Fight(MyCharacter, PenultimateFightWith, MainArena, LastFightWith, 1, "Congratulations! You won!\nYou have reached a new level: {0} and gained one stat point.", true);
                    break;
                case ConsoleKey.D2: // Fight with cipher
                    new Fight(MyCharacter, PenultimateFightWith, MainArena, LastFightWith, 0, "Congratulations! You won!", false);
                    break;
                case ConsoleKey.D0: // Exit the game
                    Environment.Exit(0);
                    break;
                default: // Upgrade stats (Stats Manager)
                    new StatsManager(MyCharacter, LastFightWith, PenultimateFightWith);
                    break;
            }
        }
    }
}
