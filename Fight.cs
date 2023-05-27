namespace swordsandsandals
{
    public class Fight
    {
        #region FIELDS

        private Character myCharacter;     // The player's character
        private Enemy actualEnemy;         // The current enemy being fought
        private Arena mainArena;           // The main arena instance
        private Enemy otherEnemy;          // The other enemy

        #endregion

        #region CONSTRUCTOR

        public Fight(Character myCharacter, Enemy actualEnemy, Arena mainArena, Enemy otherEnemy, int bounty, string winMess, bool isBoss)
        {
            this.myCharacter = myCharacter;           // Set the player's character
            this.actualEnemy = actualEnemy;           // Set the current enemy being fought
            this.mainArena = mainArena;               // Set the main arena instance
            this.otherEnemy = otherEnemy;             // Set the other enemy

            Console.Clear();                          // Clear the console screen
            Console.WriteLine("Solve math operations to deal damage to the enemy.\nPress any key to continue.");
            Console.ReadKey();                        // Wait for user input (any key press)
            Console.Clear();                          // Clear the console screen

            BattleManager battleManager = new BattleManager();  // Create a new instance of the BattleManager class
            battleManager.InitiateBattle(myCharacter, actualEnemy, mainArena, otherEnemy, bounty, winMess, isBoss); // Initiate the battle using the BattleManager instance
        }

        #endregion
    }
}
