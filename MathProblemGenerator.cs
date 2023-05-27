using System;
namespace swordsandsandals
{
    public class MathProblemGenerator //class for generating math problems
    {
        private int nextNum; // second argument in Next() method for first rand number
        private int nextNumSec; //second argument in Next() method for second rand number
        private Random random;

        public MathProblemGenerator(int nextNum, int nextNumSec)
        {
            this.nextNum = nextNum;
            this.nextNumSec = nextNumSec;
            random = new Random();
        }

        public MathProblem GenerateProblem() //this method generate math problem
        {
            int firstRandNum = random.Next(1, nextNum); //first random number
            int secRandNum = random.Next(1, nextNumSec); //second random number
            int correctAnswer = firstRandNum * secRandNum;

            return new MathProblem(firstRandNum, secRandNum, correctAnswer);
        }
    }
}

