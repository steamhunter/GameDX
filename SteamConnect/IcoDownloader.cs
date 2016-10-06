using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamConnect;
using System.IO;
using System.Net;

namespace SteamConnect
{
    class IcoDownloader
    {
        public static void getnewicons(List<Steam.SgameIconUrls> games)
        {
            foreach (var item in games)
            {
                if (!File.Exists("Content/" + item.iconurl + ".jpg"))
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile("http://media.steampowered.com/steamcommunity/public/images/apps/" + item.gameid + "/" + item.iconurl + ".jpg", "Content/" + item.iconurl + ".jpg");
                    }
                }
            }
        }
    }
}
