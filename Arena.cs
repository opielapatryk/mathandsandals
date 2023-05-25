namespace swordsandsandals
{

	public class Arena
	{
        #region FIELDS
        ConsoleKeyInfo Chinput;


        #endregion
        #region CONTRUCTOR
        public Arena(ConsoleKeyInfo chinput)
        {
            Chinput = chinput;
        }
        #endregion
        #region METHODS
        public void ChooseDuel(Character OurCharacter, Boss Andrzej, Cipher Grzesiek, Arena MainArena)
        {
            if (Chinput.Key == ConsoleKey.D1)
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

