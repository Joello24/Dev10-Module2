using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Playground
{
    public static class Helpers
    {
        public static int GetValidInt()
        {
            bool isGettingInt = true;
            int gotIt = -1;
            while (isGettingInt)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Please Enter an upper bound: ");
                Console.Write("~ ");

                int.TryParse(Console.ReadLine(), out gotIt);
                if (gotIt > 1 && gotIt < 2147483647)
                    isGettingInt = false;
            }
            Console.ResetColor();
            return gotIt;
        }
    }
}
