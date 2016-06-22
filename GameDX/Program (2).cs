using System;
using PathFinder.Debug;

namespace game
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {

            foreach (string ar in args)
            {
                if (ar == "-console=on")
                {
                   cons.consoleMsg("debug enabled");
                   
                }
            }
            using (Game1 game = new Game1())
            {
                game.Run();
            }
        }
    }
#endif
}

