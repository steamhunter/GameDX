using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Steam.steam;

namespace Steam.libs
{
    class icodownloader
    {
        public static void getnewicons(List<SgameIconUrls> games)
        {
            foreach (var item in games)
            {
                if (!File.Exists("Content/"+item.iconurl+".jpg"))
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile("http://media.steampowered.com/steamcommunity/public/images/apps/"+item.gameid+"/"+item.iconurl+".jpg","Content/"+item.iconurl+".jpg");
                    }
                }
            }
        }
    }
}
