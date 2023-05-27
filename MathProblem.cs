using System;
namespace swordsandsandals
{
    public class MathProblem
    {
        public int FirstNumber { get; } //first number in math problem
        public int SecondNumber { get; } //second number in math problem
        public int CorrectAnswer { get; } //correct answer

        public MathProblem(int firstNumber, int secondNumber, int correctAnswer)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            CorrectAnswer = correctAnswer;
        }

        public bool IsAnswerCorrect(int answer) //check if answer is correct and return true or false
        {
            return answer == CorrectAnswer; 
        }
    }
}

