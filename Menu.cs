namespace swordsandsandals
{
    public class Menu
    {
        ConsoleKeyInfo chinput;

        public Menu(Character OurCharacter,Arena MainArena, Enemy NightmasterVampire, Enemy PalugedDog)
        {   
            Console.WriteLine("Press 1 to fight with the boss\nPress 2 to fight with the cipher\nPress 0 to leave the game.\nPress any key to upgrade your statistics.");
            chinput = Console.ReadKey();

            switch (chinput.Key)
            {
                case ConsoleKey.D1:
                    new Fight(OurCharacter, PalugedDog, MainArena, NightmasterVampire, 1, "Congratulations! You won!\nYou have reached new lvl: {0} and gain one stat point.", true);
                    break;
                case ConsoleKey.D2:
                    new Fight(OurCharacter, PalugedDog, MainArena, NightmasterVampire, 0, "Congratulations! You won!", false);
                    break;
                case ConsoleKey.D0:
                    Environment.Exit(0);
                    break;
                default:
                    new StatsManager(OurCharacter, NightmasterVampire, PalugedDog);
                    break;
            }
        }
    }
}