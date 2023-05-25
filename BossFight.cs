namespace swordsandsandals
{
    public class BossFight
    {
        #region FIELDS
        public int answer;
        ConsoleKeyInfo chinput;
        #endregion
        #region CONSTRUCTOR 
        public BossFight(Character OurCharacter, Boss NightmasterVampire, Arena MainArena, Cipher PlaugedDog)
        {
            int nextNum = NightmasterVampire.NextNum;
            int nextNumSec = NightmasterVampire.NextNumSec;
            int bossHP = NightmasterVampire.Health;
            int myHP = OurCharacter.Health;
            Console.Clear();
            Console.WriteLine("Solve math operations to deal damage to enemy.\nPress any key to continue.");
            Console.ReadLine();
            Console.Clear();

            Random random = new Random();
            while ((myHP > 0) && (bossHP > 0))
            {
                Console.WriteLine("Boss: {0}\nHP: {1}\n-----------------------------\nYour HP: {2}\n-----------------------------", NightmasterVampire.Name, bossHP, myHP);

                int firstRandNum = random.Next(1, nextNum);
                int secRandNum = random.Next(1, nextNumSec);
                Console.WriteLine("{0} * {1} = ", firstRandNum, secRandNum);
                int correct = firstRandNum * secRandNum;

                try
                {
                    answer = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.Clear();

                if (correct == answer)
                {
                    Console.WriteLine("Good job!");
                    bossHP = bossHP - correct;
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Wrong!\nCorrect answer: {0}", correct);
                    myHP = myHP - correct;
                    Console.ReadLine();
                    Console.Clear();
                }

            }
            if (myHP > 0)
            {
                OurCharacter.Level += 1;
                OurCharacter.StatPoints += 1;
                NightmasterVampire.NextNum += 1;
                NightmasterVampire.NextNumSec += 1;
                Console.WriteLine("Congratulations! You won!\nYou have reached new lvl: {0} and gain one stat point.", OurCharacter.Level);
                new Menu(OurCharacter, MainArena, NightmasterVampire, PlaugedDog);
            }
            else
            {
                Console.WriteLine("What a shame! You lose..\nPress 1 to go back to menu or any key to try again.");
                chinput = Console.ReadKey();
                Console.Clear();

                switch (chinput.Key)
                {
                    case ConsoleKey.D1:
                        new Menu(OurCharacter, MainArena, NightmasterVampire, PlaugedDog);
                        break;
                    default:
                        new BossFight(OurCharacter, NightmasterVampire, MainArena, PlaugedDog);
                        break;
                }
            }
        }
        #endregion
    }
}

