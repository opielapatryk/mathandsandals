using System;

namespace swordsandsandals
{
	public class BossFight
	{
        #region FIELDS
        List<Boss> BossList = new List<Boss>()
        {
            new Boss("Mechanik Andrzej", 100, 10, 1, 1),
        };
        #endregion
        #region CONSTRUCTOR 
        public BossFight(Character OurCharacter)
		{
            int bossHP = BossList[0].Health;
            int myHP = OurCharacter.Health;
            Console.WriteLine("Rozwiązuj działania matematyczne aby przeprowadzić atak");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Statystyki przeciwnika:");
            Console.WriteLine("Boss: " + BossList[0].Name);
			Console.WriteLine("HP: " + bossHP);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Twoje HP: {0}", myHP);
            Console.WriteLine("-----------------------------");
            //while twoje hp > 0 || boss hp > 0
            //wypisz staty twoje i przeciwnika 
            //kliknij 1 aby rozpoczac atak
            //kliknij 2 aby sie wycofac 
            //case 1: generateMathTask();
            //BossAttack()
            GenerateMathTask(myHP, bossHP);
        }
        #endregion
        #region METHODS
        public void GenerateMathTask(int myHP, int bossHP)
        {
            Random random = new Random();
            //NAJPIERW BEZ TIMERA ! 
            //timer start 10 sekund
            int firstRandNum = random.Next(10);
            int secRandNum = random.Next(10);
            Console.WriteLine("{0} * {1} = ", firstRandNum, secRandNum);
            int correct = firstRandNum * secRandNum;
            int answer = Convert.ToInt32(Console.ReadLine());
            if(correct == answer)
            {
                Console.WriteLine("Dobrze");
                bossHP = bossHP - correct;

                Console.WriteLine("Statystyki przeciwnika:");
                Console.WriteLine("Boss: " + BossList[0].Name);
                Console.WriteLine("HP: " + bossHP);
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Twoje HP: {0}", myHP);
                Console.WriteLine("-----------------------------");
            }
            else
            {
                Console.WriteLine("Źle");
                myHP = myHP - correct;

                Console.WriteLine("Statystyki przeciwnika:");
                Console.WriteLine("Boss: " + BossList[0].Name);
                Console.WriteLine("HP: " + bossHP);
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Twoje HP: {0}", myHP);
                Console.WriteLine("-----------------------------");

            }
            Console.ReadLine();
            //correct = losowa liczba od 0 do 10 * losowa liczba od 0 do 10
            //if correct && czas nie minal ? BossList[0].Health -= losowa liczba
        }
        #endregion
    }
}

