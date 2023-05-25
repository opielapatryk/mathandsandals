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
        public void ChooseDuel(Character OurCharacter, Boss NightmasterVampire, Cipher PlaugedDog, Arena MainArena)
        {
            if (Chinput.Key == ConsoleKey.D1)
            {
                Console.WriteLine("Brave man! You have choosen duel with Nightmaster Vampire!");
                new BossFight(OurCharacter, NightmasterVampire, MainArena, PlaugedDog);
            }
            else
            {
                Console.WriteLine("Whoa.. Look who is there.. Paluged Dog!");
                new CipherFight(OurCharacter, NightmasterVampire, MainArena, PlaugedDog);
            }
        }
        #endregion
    }
}

