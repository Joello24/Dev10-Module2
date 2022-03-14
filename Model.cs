using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Playground
{
    internal class Model
    {
        private static int guesses;
        private static int number;

        public Model(int High)
        {
            CreateGuessInRange(High);
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public static int Guesses
        {
            get { return guesses; }
        }
        public void IncrementGuesses()
        {
            guesses++;
        }
        private void CreateGuessInRange(int high)
        {
            Random random = new Random();
            this.Number = random.Next(1, high);
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
