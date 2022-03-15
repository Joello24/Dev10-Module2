using System;

namespace Mod2Playground
{
    class GuessGameController
    {
        private static int difficulty = 0;
        public ConsoleIO UI { get; set; }
        public GameMode Mode { get; set; }
        public bool custom = true;
        public GuessGameController(ConsoleIO ui)
        {
            UI = ui;
        } 
        public void Run()
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
                        SetGameMode(ChangeGameModeMenu());
                        break;
                    case "3":
                        Console.ResetColor();
                        playing = false;
                        break;
                }
            }
        }

        private void SetGameMode(string v)
        {
            switch (v)
            {
                case "1":
                    difficulty = GameMode.EASY;
                    custom = false;
                    break;
                case "2":
                    difficulty = GameMode.MEDIUM;
                    custom = false;
                    break;
                case "3":
                    difficulty = GameMode.HARD;
                    custom = false;
                    break;
                case "4":
                    difficulty = UI.GetInt("Please enter a custom highbound: ");
                    break;
            }
        }
        private string MainMenuSelect()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nMAIN MENU");
            Console.WriteLine($"");
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
        private string ChangeGameModeMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nGAME MODE");
            Console.WriteLine("============");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Hard");
            Console.WriteLine("4. Custom");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("============");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("~ ");
            return Console.ReadLine();
        }
        private void Play()
        {
            int guess = -1;
            if (difficulty == 0)
            {
                SetGameMode(ChangeGameModeMenu());
            }
            GuessService game = new GuessService(difficulty);
            game.fakeInt = 5;
            while (game.Number != guess)
            {
                // TODO: Prompt here for highbound, or have it be based on game-mode. Pass to GetValidGuess.
                Console.WriteLine(game.ProcessGuess(guess = UI.GetValidGuess(difficulty)));
                game.IncrementGuesses();
                Console.ResetColor();
            }
        }
    }
}
