using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engine.Error.trash
{
    class error
    {
        public static void DialogFileNotFound(string filename)
        {

            Console.WriteLine("dialógús fájl nem található");
            // Application.Exit();

        }

        public static string basicError(int eid)
        {
            Console.WriteLine("hopá valami baj van" + eid + "hiba");
            return "error";
        }
    }
}