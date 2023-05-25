namespace swordsandsandals
{
    public class Menu
    {
        ConsoleKeyInfo chinput;

        public Menu(Character OurCharacter,Arena MainArena, Boss NightmasterVampire, Cipher PalugedDog)
        {   
            Console.WriteLine("Press 1 to fight with the boss\nPress 2 to fight with the cipher\nPress 0 to leave the game.\nPress any key to upgrade your statistics.");
            chinput = Console.ReadKey();

            switch (chinput.Key)
            {
                case ConsoleKey.D1:
                    new BossFight(OurCharacter, NightmasterVampire, MainArena, PalugedDog);
                    break;
                case ConsoleKey.D2:
                    new CipherFight(OurCharacter, NightmasterVampire, MainArena, PalugedDog);
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