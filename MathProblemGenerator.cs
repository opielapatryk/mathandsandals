using System;
namespace swordsandsandals
{
    public class MathProblemGenerator
    {
        private int nextNum;
        private int nextNumSec;
        private Random random;

        public MathProblemGenerator(int nextNum, int nextNumSec)
        {
            this.nextNum = nextNum;
            this.nextNumSec = nextNumSec;
            random = new Random();
        }

        public MathProblem GenerateProblem()
        {
            int firstRandNum = random.Next(1, nextNum);
            int secRandNum = random.Next(1, nextNumSec);
            int correctAnswer = firstRandNum * secRandNum;

            return new MathProblem(firstRandNum, secRandNum, correctAnswer);
        }
    }
}

