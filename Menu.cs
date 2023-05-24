
namespace swordsandsandals
{
    public class Menu
    {
        private string userInput;

        public Menu(Character OurCharacter,Arena MainArena, Boss Andrzej, Cipher Grzesiek)
        {
            
            Console.WriteLine("Wcisnij klawisz 1 aby przejsc do walki z bossem, 2 aby przejsc do walki ze zwyklym rzezimieszkiem lub inny klawisz aby przejsc do panelu statystyk. ");
            Console.WriteLine("WPISZ 0 ABY WYJSC Z GRY");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":

                    new BossFight(OurCharacter, Andrzej, MainArena, Grzesiek);

                    break;
                case "2":

                    new CipherFight(OurCharacter, Grzesiek, MainArena, Andrzej);

                    break;
                case "0":

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