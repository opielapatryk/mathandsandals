using System;

namespace swordsandsandals
{
	public class BossFight
	{
        #region FIELDS
        public int answer;
        private string userInput;
        List<Boss> BossList = new List<Boss>()
        {
            new Boss("Mechanik Andrzej", 100, 1),
        };
        #endregion
        #region CONSTRUCTOR 
        public BossFight(Character OurCharacter)
		{
            int bossHP = BossList[0].Health;
            int myHP = OurCharacter.Health;
            Console.WriteLine("Rozwiązuj działania matematyczne aby przeprowadzić atak");
            Console.ReadLine();
            Console.Clear();
           
            Random random = new Random();
            while ((myHP>0) && (bossHP>0))
            {
                Console.WriteLine("Statystyki przeciwnika:");
                Console.WriteLine("Boss: " + BossList[0].Name);
                Console.WriteLine("HP: " + bossHP);
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Twoje HP: {0}", myHP);
                Console.WriteLine("-----------------------------");

                int firstRandNum = random.Next(10);
                int secRandNum = random.Next(10);
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
                    Console.WriteLine("Dobrze!");
                    bossHP = bossHP - correct;
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Źle!");
                    Console.WriteLine("Poprawna odpowiedź: {0}", correct);
                    myHP = myHP - correct;
                    Console.ReadLine();
                    Console.Clear();
                    
                }
                
            }
            if (myHP > 0)
            {
                OurCharacter.Level += 1;
                OurCharacter.StatPoints += 1;
                Console.WriteLine("GRATULACJE! WYGRAŁEŚ POJEDYNEK! Dzięki czemu zyskujesz kolejny lvl: {0}, oraz punkt statystyk.", OurCharacter.Level);
                new Menu(OurCharacter);
            }
            else
            {
                Console.WriteLine("NIESTETY! PONIOSŁEŚ PORAŻKĘ..");
                Console.WriteLine("Wciśnij 1. ABY WRÓCIĆ DO MENU LUB INNY KLAWISZ W CELU POWTÓRZENIA WALKI");
                userInput = Console.ReadLine();
                Console.Clear();
                switch (userInput)
                {
                    case "1":
                        new Menu(OurCharacter);
                        break;
                    default:
                        new BossFight(OurCharacter);
                        break;
                }
            }
        }
           
        #endregion
        #region METHODS
        #endregion
    }
}

