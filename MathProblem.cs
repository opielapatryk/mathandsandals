using System;
namespace swordsandsandals
{
    public class MathProblem
    {
        public int FirstNumber { get; }
        public int SecondNumber { get; }
        public int CorrectAnswer { get; }

        public MathProblem(int firstNumber, int secondNumber, int correctAnswer)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            CorrectAnswer = correctAnswer;
        }

        public bool IsAnswerCorrect(int answer)
        {
            return answer == CorrectAnswer;
        }
    }
}

