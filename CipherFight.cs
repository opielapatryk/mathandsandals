namespace swordsandsandals
{
    public class CipherFight
    {
        #region FIELDS
        public int answer;
        ConsoleKeyInfo chinput;
        #endregion
        #region CONSTRUCTOR 
        public CipherFight(Character OurCharacter, Boss NightmasterVampire, Arena MainArena, Cipher PlaugedDog)
        {
            int nextNum = PlaugedDog.NextNum;
            int nextNumSec = PlaugedDog.NextNumSec;
            int bossHP = PlaugedDog.Health;
            int myHP = OurCharacter.Health;
            Console.Clear();
            Console.WriteLine("Solve math operations to deal damage to enemy.\nPress any key to continue.");
            Console.ReadLine();
            Console.Clear();

            Random random = new Random();
            while ((myHP > 0) && (bossHP > 0))
            {
                Console.WriteLine("Cipher: {0}\nHP: {1}\n-----------------------------\nYour HP: {2}\n-----------------------------", PlaugedDog.Name, bossHP, myHP);

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
                PlaugedDog.NextNum += 1;
                PlaugedDog.NextNumSec += 1;
                Console.WriteLine("Congratulations! You won!");
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
                        new CipherFight(OurCharacter, NightmasterVampire, MainArena, PlaugedDog);
                        break;
                }
            }
        }

        #endregion
    }
}

