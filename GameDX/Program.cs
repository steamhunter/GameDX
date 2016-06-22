using PathFinder.Debug;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDX
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            foreach (string ar in args)
            {
                if (ar == "-console=on")
                {
                    cons.consoleMsg("debug enabled");

                }
            }
            using (GameDX game = new GameDX())
            {
                game.Run();
            }
        }
    }
}
