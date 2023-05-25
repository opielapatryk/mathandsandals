
namespace swordsandsandals
{
    public class Menu
    {
        ConsoleKeyInfo chinput;

        public Menu(Character OurCharacter,Arena MainArena, Boss Andrzej, Cipher Grzesiek)
        {
            
            Console.WriteLine("Wcisnij klawisz 1 aby przejsc do walki z bossem, 2 aby przejsc do walki ze zwyklym rzezimieszkiem lub inny klawisz aby przejsc do panelu statystyk. ");
            Console.WriteLine("WPISZ 0 ABY WYJSC Z GRY");
            chinput = Console.ReadKey();


            switch (chinput.Key)
            {
                case ConsoleKey.D1:

                    new BossFight(OurCharacter, Andrzej, MainArena, Grzesiek);

                    break;
                case ConsoleKey.D2:

                    new CipherFight(OurCharacter, Grzesiek, MainArena, Andrzej);

                    break;
                case ConsoleKey.D0:
                    Environment.Exit(0);

                    break;
                    

                default:
                    new StatsManager(OurCharacter, Andrzej, Grzesiek);
                    break;
            }
            
        }
    }
}

//Console.WriteLine("WCIŚNIJ 1. ABY PRZEJŚĆ DO KOLEJNEJ WALKI LUB INNY KLAWISZ W CELU ULEPSZENIA BĄDŹ SPRAWDZENIA STATYSTYK!");
//string choice = Console.ReadLine();
//if (choice == "1")
//{

//}