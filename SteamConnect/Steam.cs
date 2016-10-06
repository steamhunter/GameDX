using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamConnect.Exeptions;
using System.Diagnostics;

namespace SteamConnect
{
    public class Steam
    {

        private static string steamloc = Registry.GetValue("HKEY_CURRENT_USER\\Software\\Valve\\Steam", "SteamPath", null).ToString();
        private static string[] libary;
        private static List<string> steamdirs = new List<string>();
        public static List<string> gamenames = new List<string>();
        private static List<string> gameids = new List<string>();
        public struct SgameIconUrls
        {
            public int gameid;
            public string iconurl;
            public string name;
        }
        public static List<SgameIconUrls> Gameicourl = new List<SgameIconUrls>();
        public static JSONDownloader jdownl = new JSONDownloader();
        public static void loadsteam()
        {

            libary = File.ReadAllLines(steamloc + "\\steamapps\\libraryfolders.vdf");
            foreach (var item in libary)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (item.Contains("\"" + i + "\""))
                    {
                        string sv = item.Trim().Remove(0, 3).Trim().Trim('"');
                        steamdirs.Add(sv);

                    }
                }

            }
            string[] games = { };
            foreach (var item in steamdirs)
            {
                int lnght = item.Length + 11;
                games = Directory.GetFiles(item + "\\steamapps");
                for (int i = 0; i < games.Length; i++)
                {
                    string[] content = File.ReadLines(games[i]).ToArray();
                    foreach (var cntnt in content)
                    {
                        if (cntnt.Contains("\"name\""))
                        {
                            string sv = cntnt.Trim().Remove(0, 6).Trim().Trim('"');

                            gamenames.Add(sv);

                        }
                        if (cntnt.Contains("\"appid\""))
                        {
                            string sv = cntnt.Trim().Remove(0, 7).Trim().Trim('"');

                            gameids.Add(sv);

                        }
                    }
                }

            }

            for (int i = 1; i < gamenames.ToArray().Length; i++)
            {
                if (gamenames[i] == gamenames[i - 1])
                {
                    gamenames.Remove(gamenames[i]);
                }
            }
            JSONDownloader.jsonrespond respond = jdownl.getJSON();
            foreach (var item in gameids)
            {
                for (int i = 0; i < respond.response.games.Count(); i++)
                {
                    if (respond.response.games[i].appid == int.Parse(item))
                    {
                        SgameIconUrls sgu = new SgameIconUrls();
                        sgu.gameid = respond.response.games[i].appid;
                        sgu.iconurl = respond.response.games[i].img_logo_url;
                        sgu.name = respond.response.games[i].name;
                        Gameicourl.Add(sgu);
                    }
                }
            }
            IcoDownloader.getnewicons(Gameicourl);
        }
        public static void startgame(int id)
        {

            if (id == -1)
            {
                throw new  GameNotFoundException("required parameter id was not defined");
              
            }
            else
            {
                Process.Start(Steam.steamloc + "\\steam.exe", " -applaunch " + Steam.gameids[id]);
            }
        }
        public static void startgamebyappid(int id)
        {




            Process.Start(Steam.steamloc + "\\steam.exe", " -applaunch " + id);

        }
    }
}
