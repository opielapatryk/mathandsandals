using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;


namespace swordsandsandals
{

    public class CipherFight
    {
        #region FIELDS

        public int answer;
        ConsoleKeyInfo chinput;
        #endregion
        #region CONSTRUCTOR 
        public CipherFight(Character OurCharacter, Cipher Grzesiek, Arena MainArena, Boss Andrzej)
        {
            int nextNum = Grzesiek.NextNum;
            int nextNumSec = Grzesiek.NextNumSec;
            int bossHP = Grzesiek.Health;
            int myHP = OurCharacter.Health;
            Console.WriteLine("Rozwiązuj działania matematyczne aby przeprowadzić atak");
            Console.ReadLine();
            Console.Clear();

            Random random = new Random();
            while ((myHP > 0) && (bossHP > 0))
            {
                Console.WriteLine("Statystyki przeciwnika:");
                Console.WriteLine("Rzemieszniczek: " + Grzesiek.Name);
                Console.WriteLine("HP: " + bossHP);
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Twoje HP: {0}", myHP);
                Console.WriteLine("-----------------------------");


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

                Grzesiek.NextNum += 1;
                Grzesiek.NextNumSec += 1;
                Console.WriteLine("GRATULACJE! WYGRAŁEŚ POJEDYNEK! Dzięki czemu zyskujesz kolejny lvl: {0}, oraz punkt statystyk.", OurCharacter.Level);




                new Menu(OurCharacter, MainArena, Andrzej, Grzesiek);
            }
            else
            {
                Console.WriteLine("NIESTETY! PONIOSŁEŚ PORAŻKĘ..");
                Console.WriteLine("Wciśnij 1. ABY WRÓCIĆ DO MENU LUB INNY KLAWISZ W CELU POWTÓRZENIA WALKI");
                chinput = Console.ReadKey();

                Console.Clear();
                switch (chinput.Key)
                {
                    case ConsoleKey.D1:
                        new Menu(OurCharacter, MainArena, Andrzej, Grzesiek);
                        break;
                    default:
                        new CipherFight(OurCharacter, Grzesiek, MainArena, Andrzej);
                        break;
                }
            }
        }

        #endregion
        #region METHODS
        #endregion
    }
}

