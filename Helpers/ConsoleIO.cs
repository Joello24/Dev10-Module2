using System;

namespace Mod2Playground
{
    class ConsoleIO
    {
        public int GetInt(string prompt)
        {
            int result = -1;
            bool valid = false;
            while (!valid)
            {
                Console.Write($"{prompt}: ");
                if (!int.TryParse(Console.ReadLine(), out result))
                {
                    Error("Please input a proper integer\n\n");
                }
                else
                {
                    valid = true;
                }
            }
            return result;
        }
        public int GetValidGuess(int highbound)
        {
            bool isGettingInt = true;
            int gotIt = -1;
            while (isGettingInt)
            {
                Console.ForegroundColor= ConsoleColor.Green;

                Console.WriteLine($"Please Enter a guess 1-{highbound}: ");
                Console.Write("~ ");
                int.TryParse(Console.ReadLine(), out gotIt);
                if (gotIt > 1 && gotIt < highbound)
                    isGettingInt = false;
            }
            Console.ResetColor();
            return gotIt;
        }
        public void Display(string message)
        {
            Console.WriteLine(message);
        }
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Display(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Warn(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Display(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
