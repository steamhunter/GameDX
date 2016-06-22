using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Engine.Debug;


namespace dwtdxna
{
    class worldlang
    {
        public static void worldRead(string worldid)
        {
            StreamReader r = new StreamReader(worldid + ".world", Encoding.Default);
            while (!r.EndOfStream)
            {
                string sv = r.ReadLine();
                bool ready = false;
                while (ready == false)
                {
                    if (sv[0] == '\t')
                    {
                        sv = stringmuvelet.reorder(sv);
                    }
                    else ready = true;
                }

                switch (sv)
                {
                    case "entity": cons.consoleMsg("entity"); break;
                    case "world": cons.consoleMsg("world"); break;




                    default:
                        break;
                }
            }
        }
    }


    class stringmuvelet
    {
        public static string reorder(string input)
        {
            string sv = "";
            for (int i = 0; i < input.Length - 1; i++)
            {
                sv += input[i + 1];
            }
            return sv;
        }

    }


}

