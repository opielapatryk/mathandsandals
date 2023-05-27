using System;

namespace swordsandsandals
{
    public class ConsoleInteraction
    {
        // Displays the current battle status, including the enemy's name and health, and the player's health.
        public void DisplayBattleStatus(string enemyName, int enemyHP, int playerHP)
        {
            Console.WriteLine("Boss: {0}\nHP: {1}\n-----------------------------\nYour HP: {2}\n-----------------------------", enemyName, enemyHP, playerHP);
        }

        // Displays a math problem to the player.
        public void DisplayMathProblem(MathProblem problem)
        {
            Console.WriteLine("{0} * {1} = ", problem.FirstNumber, problem.SecondNumber);
        }

        // Displays a win message with the player's new level.
        public void DisplayWinMessage(int level)
        {
            Console.WriteLine("Congratulations! You won!\nYou have reached new level: {0} and gained one stat point.", level);
        }

        // Reads the player's answer from the console and converts it to an integer.
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

        // Displays a message when the player's answer is incorrect, showing the correct answer.
        public void DisplayWrongAnswer(int correctAnswer)
        {
            Console.WriteLine("Wrong!\nCorrect answer: {0}", correctAnswer);
        }

        // Clears the console screen.
        public void ClearConsole()
        {
            Console.Clear();
        }

        // Displays a lose message and prompts the player to go back to the menu or try again.
        public void DisplayLoseMessage()
        {
            Console.WriteLine("What a shame! You lose..\nPress 1 to go back to the menu or any key to try again.");
        }

        // Reads the player's input and determines whether they want to go back to the menu.
        public bool BackToMenu()
        {
            ConsoleKeyInfo chinput = Console.ReadKey();
            Console.Clear();
            return chinput.Key == ConsoleKey.D1;
        }

        // Displays a message when the player's answer is correct.
        public void DisplayCorrectAnswer()
        {
            Console.WriteLine("Good job!");
        }
    }
}
