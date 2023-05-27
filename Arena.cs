namespace swordsandsandals
{
    public class Arena
    {
        #region FIELDS

        ConsoleKeyInfo Chinput; // Store the chosen key by the user

        #endregion

        #region CONSTRUCTOR

        public Arena(ConsoleKeyInfo chinput)
        {
            Chinput = chinput; // Initialize the Chinput field with the provided ConsoleKeyInfo
        }

        #endregion

        #region METHODS

        public void ChooseDuel(Character myCharacter, Enemy Boss, Enemy Cipher, Arena MainArena)
        {
            if (Chinput.Key == ConsoleKey.D1) // If the chosen key is '1'
            {
                Console.WriteLine("Brave man! You have chosen to duel with Nightmaster Vampire!");
                new Fight(myCharacter, Boss, MainArena, Cipher, 1, "Congratulations! You won!\nYou have reached new lvl: {0} and gain one stat point.", true);
            }
            else if (Chinput.Key == ConsoleKey.D2) // If the chosen key is '2'
            {
                Console.WriteLine("Whoa.. Look who is there.. Plagued Dog!");
                new Fight(myCharacter, Cipher, MainArena, Boss, 0, "Congratulations! You won!", false);
            }
        }

        #endregion
    }
}
