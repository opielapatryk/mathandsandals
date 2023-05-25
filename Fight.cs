namespace swordsandsandals
{
    public class Fight
    {
        #region FIELDS
        public int answer;
        public string actualEnemyName;
        ConsoleKeyInfo chinput;
        #endregion
        #region CONSTRUCTOR 
        public Fight(Character MyCharacter, Enemy ActualEnemy, Arena MainArena, Enemy OtherEnemy, int bounty, string winMess, bool isBoss)
        {
            int nextNum = ActualEnemy.NextNum;
            int nextNumSec = ActualEnemy.NextNumSec;
            actualEnemyName = ActualEnemy.Name;
            int bossHP = ActualEnemy.Health;
            int myHP = MyCharacter.Health;
            Console.Clear();
            Console.WriteLine("Solve math operations to deal damage to enemy.\nPress any key to continue.");
            Console.ReadLine();
            Console.Clear();
            new Multiply(myHP,bossHP,nextNum,nextNumSec,answer, actualEnemyName);
           
            if (myHP > 0)
            {
                MyCharacter.Level += bounty;
                MyCharacter.StatPoints += bounty;
                ActualEnemy.NextNum += 1;
                ActualEnemy.NextNumSec += 1;
                Console.WriteLine(winMess, MyCharacter.Level);
                new Menu(MyCharacter, MainArena, ActualEnemy, OtherEnemy);
            }
            else
            {
                Console.WriteLine("What a shame! You lose..\nPress 1 to go back to menu or any key to try again.");
                chinput = Console.ReadKey();
                Console.Clear();

                if(chinput.Key == ConsoleKey.D1)
                {
                    new Menu(MyCharacter, MainArena, ActualEnemy, OtherEnemy);

                }else if (isBoss)
                {
                    new Fight(MyCharacter, ActualEnemy, MainArena, OtherEnemy, 1, "Congratulations! You won!\nYou have reached new lvl: {0} and gain one stat point.", true);
                }
                else
                {
                    new Fight(MyCharacter, ActualEnemy, MainArena, OtherEnemy, 0, "Congratulations! You won!", false);
                }
            }
        }
        #endregion
    }
}

