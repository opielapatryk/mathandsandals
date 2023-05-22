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
                    Console.WriteLine("1. health: {0} | 2. mana: {1} | 3. damage: {2} | 4. magic damage: {3} | 5. agility: {4} | 0. Wyjdź", OurCharacter.Health, OurCharacter.Mana, OurCharacter.Damage, OurCharacter.MagicDamage, OurCharacter.Agility);
                    userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "1":
                            OurCharacter.StatPoints -= 1;
                            OurCharacter.Health += 1;
                            break;
                        case "2":
                            OurCharacter.StatPoints -= 1;
                            OurCharacter.Mana += 1;
                            break;
                        case "3":
                            OurCharacter.StatPoints -= 1;
                            OurCharacter.Damage += 1;
                            break;
                        case "4":
                            OurCharacter.StatPoints -= 1;
                            OurCharacter.MagicDamage += 1;
                            break;
                        case "5":
                            OurCharacter.StatPoints -= 1;
                            OurCharacter.Agility += 1;
                            break;
                        default:
                            Console.WriteLine("przejdz do areny!");
                            break;
                    }
                }
                while ((OurCharacter.StatPoints > 0) && ((userInput == "1") || (userInput == "2") || (userInput == "3") || (userInput == "4") || (userInput == "5")));
                Console.WriteLine("przejdz do areny!");
            }
            else
            {
                Console.WriteLine("Niestety nie masz wystarczającej ilości punktów aby zwiększyć statystyki. 1. health: {0} | 2. mana: {1} | 3. damage: {2} | 4. magic damage: {3} | 5. agility: {4}", OurCharacter.Health, OurCharacter.Mana, OurCharacter.Damage, OurCharacter.MagicDamage, OurCharacter.Agility);
                Console.WriteLine("Przejdź do areny!");
                
                
            }
            
            do
            {
                Console.WriteLine("Wybierz typ przeciwnika!");
                Console.WriteLine("1. Boss | 2. Cipher");
                typeOfDuel = Console.ReadLine();
            } while ((typeOfDuel != "1") && (typeOfDuel != "2"));
            Arena MainArena = new Arena(typeOfDuel);
            MainArena.ChooseDuel();
        }
#endregion
    }
}

