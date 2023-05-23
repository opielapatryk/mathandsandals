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
           
            Random random = new Random();
            while ((myHP>0) && (bossHP>0))
            {
                int firstRandNum = random.Next(10);
                int secRandNum = random.Next(10);
                Console.WriteLine("{0} * {1} = ", firstRandNum, secRandNum);
                int correct = firstRandNum * secRandNum;
                int answer = Convert.ToInt32(Console.ReadLine());
                if (correct == answer)
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
            }
            if (myHP > 0)
            {
                Console.WriteLine("GRATULACJE! WYGRAŁEŚ POJEDYNEK!");
                //OTO TWOJA NAGRODA BOUNTY.. COS TAM PRZEJDZ DO MENU ABY ULEPSZYC STATYSTYKI
                new Menu();
            }
            else
            {
                Console.WriteLine("NIESTETY! PONIOSŁEŚ PORAŻKĘ..");
                Console.WriteLine("Wciśnij 1. ABY WRÓCIĆ DO MENU LUB INNY KLAWISZ W CELU POWTÓRZENIA WALKI");
                new Menu();
                Console.ReadLine();

            }
        }
           
        #endregion
        #region METHODS
        #endregion
    }
}

