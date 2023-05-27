using System;

namespace swordsandsandals
{
    public class BattleManager
    {
        public void InitiateBattle(Character myCharacter, Enemy actualEnemy, Arena mainArena, Enemy otherEnemy, int bounty, string winMess, bool isBoss)
        {
            ConsoleInteraction consoleInteraction = new ConsoleInteraction(); // Create an instance of ConsoleInteraction for console interactions

            int enemyHP = actualEnemy.Health; // Store the current enemy's health
            int myHP = myCharacter.Health; // Store the player's health

            while (myHP > 0 && enemyHP > 0)
            {
                Console.WriteLine("Boss: {0}\nHP: {1}\n-----------------------------\nYour HP: {2}\n-----------------------------", actualEnemy.Name, enemyHP, myHP);

                MathProblemGenerator problemGenerator = new MathProblemGenerator(actualEnemy.NextNum, actualEnemy.NextNumSec); // Create a MathProblemGenerator instance with enemy's numbers
                MathProblem mathProblem = problemGenerator.GenerateProblem(); // Generate a math problem using the generator
                consoleInteraction.DisplayMathProblem(mathProblem); // Display the math problem to the player

                int answer = consoleInteraction.ReadAnswer(); // Read the player's answer from the console

                if (mathProblem.IsAnswerCorrect(answer)) // Check if the answer is correct
                {
                    Console.WriteLine("Good job!");
                    enemyHP -= mathProblem.CorrectAnswer; // Reduce enemy's health by the correct answer value
                }
                else
                {
                    Console.WriteLine("Wrong!\nCorrect answer: {0}", mathProblem.CorrectAnswer);
                    myHP -= mathProblem.CorrectAnswer; // Reduce player's health by the correct answer value
                }

                consoleInteraction.ClearConsole(); // Clear the console screen
            }

            if (myHP > 0) // Player wins the battle
            {
                myCharacter.Level += bounty; // Increase player's level by the bounty value
                myCharacter.StatPoints += bounty; // Increase player's stat points by the bounty value
                actualEnemy.NextNum += 1; // Increase enemy's next numbers for future battles
                actualEnemy.NextNumSec += 1;
                Console.WriteLine(winMess, myCharacter.Level); // Display the win message with the player's new level
                new Menu(myCharacter, mainArena, actualEnemy, otherEnemy); // Return to the main menu
            }
            else // Player loses the battle
            {
                consoleInteraction.DisplayLoseMessage(); // Display the lose message

                if (consoleInteraction.BackToMenu()) // Check if the player wants to go back to the main menu
                {
                    new Menu(myCharacter, mainArena, actualEnemy, otherEnemy); // Return to the main menu
                }
                else if (isBoss) // If it was a boss battle, initiate a new boss fight
                {
                    new Fight(myCharacter, actualEnemy, mainArena, otherEnemy, 1, "Congratulations! You won!\nYou have reached new lvl: {0} and gain one stat point.", true);
                }
                else // If it was a regular enemy battle, initiate a new regular enemy fight
                {
                    new Fight(myCharacter, actualEnemy, mainArena, otherEnemy, 0, "Congratulations! You won!", false);
                }
            }
        }
    }
}
