using System;

namespace Mod2Playground
{
    class GameController
    {
        public static void Run()
        {
            bool playing = true;
            while (playing)
            {
                switch (MainMenuSelect())
                {
                    case "1":
                        Console.ResetColor();
                        Play();
                        break;
                    case "2":
                        Console.ResetColor();
                        ChangeGameMode();
                        break;
                    case "3":
                        Console.ResetColor();
                        playing = false;
                        break;
                }
            }
        }
        private static string MainMenuSelect()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nMAIN MENU");
            Console.WriteLine("============");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1. Play");
            Console.WriteLine("2. Change game mode");
            Console.WriteLine("3. Exit");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("============");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("~ ");
            return Console.ReadLine();  
        }
        private static void ChangeGameMode()
        {
            throw new NotImplementedException();
        }
        private static void Play()
        {
            int guess = -1;
            Model game = new Model(GetValidInt());
            while (game.Number != guess)
            {
                Console.WriteLine(game.ProcessGuess(guess = GetValidGuess()));
                game.IncrementGuesses();
                Console.ResetColor();
            }
        }

        private static int GetValidGuess()
        {
            bool isGettingInt = true;
            int gotIt = -1;
            while (isGettingInt)
            {
                Console.ForegroundColor= ConsoleColor.Green;

                Console.WriteLine("Please Enter a guess 1-100: ");
                Console.Write("~ ");
                int.TryParse(Console.ReadLine(), out gotIt);
                if (gotIt > 1 && gotIt < 101)
                    isGettingInt = false;
            }
            Console.ResetColor();
            return gotIt;
        }

        private static int GetValidInt()
        {
            bool isGettingInt = true;
            int gotIt = -1;
            while (isGettingInt)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Please Enter an upper bound 1-100: ");
                Console.Write("~ ");
                int.TryParse(Console.ReadLine(), out gotIt);
                if (gotIt > 1 && gotIt < 101)
                    isGettingInt = false;
            }
            Console.ResetColor();
            return gotIt;
        }


    }
}
