
namespace swordsandsandals
{
    public class Menu
    {
        private string userInput;

        public Menu(Character OurCharacter,Boss Andrzej)
        {
            
            Console.WriteLine("Wcisnij klawisz 1 aby przejsc do panelu statystyk, lub inny klawisz aby stoczyc pojedynek.");
            userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    new StatsManager(OurCharacter, Andrzej);
                    break;
                default:
                    new BossFight(OurCharacter, Andrzej);
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