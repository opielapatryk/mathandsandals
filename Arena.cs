namespace swordsandsandals
{

	public class Arena
	{
        #region FIELDS
        public string TypeOfDuel;
        

        #endregion
        #region CONTRUCTOR
        public Arena(string typeOfDuel)
        {
            TypeOfDuel = typeOfDuel;
        }
        #endregion
        #region METHODS
        public void ChooseDuel(Character OurCharacter, Boss Andrzej, Cipher Grzesiek, Arena MainArena)
        {
            if (TypeOfDuel == "1")
            {
                Console.WriteLine("Ejże!.. wybrałeś pojedynek z bossem!");
                new BossFight(OurCharacter, Andrzej, MainArena, Grzesiek);
            }
            else
            {
                Console.WriteLine("Wybrałeś pojedynek ze zwykłym szemranym rzezimieszkiem!");
                new CipherFight(OurCharacter, Grzesiek, MainArena, Andrzej);
            }
        }
        #endregion
    }
}

