using System;
namespace swordsandsandals
{
    public class ConsoleInteraction
    {
        public void DisplayBattleStatus(string enemyName, int enemyHP, int playerHP)
        {
            Console.WriteLine("Boss: {0}\nHP: {1}\n-----------------------------\nYour HP: {2}\n-----------------------------", enemyName, enemyHP, playerHP);
        }

        public void DisplayMathProblem(MathProblem problem)
        {
            Console.WriteLine("{0} * {1} = ", problem.FirstNumber, problem.SecondNumber);
        }
        public void DisplayWinMessage(int level)
        {
            Console.WriteLine("Congratulations! You won!\nYou have reached new level: {0} and gained one stat point.", level);
        }

        public int ReadAnswer()
        {
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public void DisplayWrongAnswer(int correctAnswer)
        {
            Console.WriteLine("Wrong!\nCorrect answer: {0}", correctAnswer);
        }

        public void ClearConsole()
        {
            Console.Clear();
        }

        public void DisplayLoseMessage()
        {
            Console.WriteLine("What a shame! You lose..\nPress 1 to go back to the menu or any key to try again.");
        }

        public bool BackToMenu()
        {
            ConsoleKeyInfo chinput = Console.ReadKey();
            Console.Clear();
            return chinput.Key == ConsoleKey.D1;
        }
        public void DisplayCorrectAnswer()
        {
            Console.WriteLine("Good job!");
        }
    }
}

