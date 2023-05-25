namespace swordsandsandals
{

	public class StatsManager
	{
        #region FIELDS
        private string userInput;
        private string typeOfDuel;
        #endregion
        #region CONSTRUCTOR
        public StatsManager(Character OurCharacter, Boss Andrzej, Cipher Grzesiek)
		{
            Console.Clear();
            ConsoleKeyInfo chinput;

            if (OurCharacter.StatPoints > 0)
            {
                do
                {
                    Console.WriteLine("Pozostało ci do wykorzystania {0} puntków statystyk!", OurCharacter.StatPoints);
                    Console.WriteLine("1. health: {0} | 2. agility: {1} | 0. Wyjdź", OurCharacter.Health, OurCharacter.Agility);
                    chinput = Console.ReadKey();

                    switch (chinput.Key)
                    {
                        case ConsoleKey.D1:
                            OurCharacter.StatPoints -= 1;
                            OurCharacter.Health += 1;
                            break;
                        case ConsoleKey.D2:
                            OurCharacter.StatPoints -= 1;
                            OurCharacter.Agility += 1;
                            break;
                        default:
                            Console.WriteLine("przejdz do areny!");
                            break;
                    }
                    Console.Clear();
                }
                while ((OurCharacter.StatPoints > 0) && ((chinput.Key == ConsoleKey.D1) || (chinput.Key == ConsoleKey.D2)));
                Console.WriteLine("Przejdź do areny!");

            }
            else
            {
                Console.WriteLine("Niestety nie masz wystarczającej ilości punktów aby zwiększyć statystyki. 1. health: {0} | 2. agility: {1}", OurCharacter.Health, OurCharacter.Agility);
                Console.WriteLine("Przejdź do areny!");
                
                
            }
            
            do
            {
                Console.WriteLine("Wybierz typ przeciwnika!");
                Console.WriteLine("1. Boss | 2. Rzezimieszek");
                chinput = Console.ReadKey();
                Console.Clear();

            } while ((chinput.Key == ConsoleKey.D1) && (chinput.Key == ConsoleKey.D2));
            //save
            //kod
            //save
            Arena MainArena = new Arena(chinput);
            MainArena.ChooseDuel(OurCharacter, Andrzej, Grzesiek, MainArena);

        }
#endregion
    }
}

