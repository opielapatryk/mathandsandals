namespace swordsandsandals
{
    public class Fight
    {
        #region FIELDS
        private Character myCharacter;
        private Enemy actualEnemy;
        private Arena mainArena;
        private Enemy otherEnemy;
        #endregion

        #region CONSTRUCTOR
        public Fight(Character myCharacter, Enemy actualEnemy, Arena mainArena, Enemy otherEnemy, int bounty, string winMess, bool isBoss)
        {
            this.myCharacter = myCharacter;
            this.actualEnemy = actualEnemy;
            this.mainArena = mainArena;
            this.otherEnemy = otherEnemy;

            Console.Clear();
            Console.WriteLine("Solve math operations to deal damage to the enemy.\nPress any key to continue.");
            Console.ReadKey();
            Console.Clear();

            BattleManager battleManager = new BattleManager();
            battleManager.InitiateBattle(myCharacter, actualEnemy, mainArena, otherEnemy, bounty, winMess, isBoss);
        }
        #endregion
    }
}