namespace swordsandsandals
{
	public class StatsManager
	{
        #region FIELDS
        private string userInput;
        private string typeOfDuel;
        #endregion
        #region CONSTRUCTOR
        public StatsManager(Character OurCharacter)
		{
            if (OurCharacter.StatPoints > 0)
            {
                do
                {
                    Console.WriteLine("Pozostało ci do wykorzystania {0} puntków statystyk!", OurCharacter.StatPoints);
                    Console.WriteLine("1. health: {0} | 2. agility: {1} | 0. Wyjdź", OurCharacter.Health, OurCharacter.Agility);
                    userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "1":
                            OurCharacter.StatPoints -= 1;
                            OurCharacter.Health += 1;
                            break;
                        case "2":
                            OurCharacter.StatPoints -= 1;
                            OurCharacter.Agility += 1;
                            break;
                        default:
                            Console.WriteLine("przejdz do areny!");
                            break;
                    }
                }
                while ((OurCharacter.StatPoints > 0) && ((userInput == "1") || (userInput == "2")));
                Console.WriteLine("przejdz do areny!");
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
                typeOfDuel = Console.ReadLine();
            } while ((typeOfDuel != "1") && (typeOfDuel != "2"));
            Arena MainArena = new Arena(typeOfDuel);
            MainArena.ChooseDuel(OurCharacter);
        }
#endregion
    }
}

