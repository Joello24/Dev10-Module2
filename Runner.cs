using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Playground
{
    internal class Runner
    {
        public static void Main(string[] args)
        {
            //GameController.Run();

            ConsoleIO io = new ConsoleIO();

            GuessGameController Game = new GuessGameController(io);
            Game.Run();
        }
    }
}
