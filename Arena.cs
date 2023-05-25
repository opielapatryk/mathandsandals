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
        public void ChooseDuel(Character myCharacter, Enemy Boss, Enemy Cipher, Arena MainArena)
        {
            if (Chinput.Key == ConsoleKey.D1)
            {
                Console.WriteLine("Brave man! You have choosen duel with Nightmaster Vampire!");
                new Fight(myCharacter, Boss, MainArena, Cipher, 1, "Congratulations! You won!\nYou have reached new lvl: {0} and gain one stat point.",true);
            }
            else
            {
                Console.WriteLine("Whoa.. Look who is there.. Paluged Dog!");
                new Fight(myCharacter, Cipher, MainArena, Boss, 0, "Congratulations! You won!",false);
            }
        }
        #endregion
    }
}

