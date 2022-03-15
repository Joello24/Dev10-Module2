using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Playground
{
    internal class GuessService
    {
        public int guesses
            { get; set; }

        private int number;
        public int highBound;
        public int fakeInt;

        public GuessService(int High)
        {
            CreateGuessInRange(High);
            this.highBound = High;
        }
        public int Number
        {
            get { return number; }
        }
        public void IncrementGuesses()
        {
            guesses++;
        }
        private void CreateGuessInRange(int high)
        {
            Random random = new Random();
            this.number = random.Next(1, high);
        }
        public string ProcessGuess(int Guess)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string message = "";

            if (Guess > number)
            {
                message += "Too high, guess again!";
            }
            else if (Guess < number)
            {
                message += "Too low, guess again!";
            }
            else
            {
                message += $"Congratulations, you win! You got it in {guesses} guesses!";
            }
            return message;
        }
    }
}
