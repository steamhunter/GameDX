using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Steam.libs
{
    public class jsondownloader
    {
        public class jsonrespond
        {
            public intrespond response { get; set; }
        }
        public class intrespond
        {
            public int total_count { get; set; }
            public Games[] games { get; set; }

        }
        public class Games
        {
            public int appid { get; set; }
            public string name { get; set; }
            public int playtime_2weeks { get; set; }
            public int playtime_forever { get; set; }
            public string img_icon_url { get; set; }
            public string img_logo_url { get; set; }
        }
        public jsonrespond getJSON()
        {
            using (var client = new WebClient())
            {
                client.DownloadFile("http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key=8F83828068020B91BE744441CB0CC49B&steamid=76561198037767789&format=json&include_appinfo=1", "json.json");
            }
            string jsonstring = File.ReadAllText("json.json");
            JavaScriptSerializer ser = new JavaScriptSerializer();
            jsonrespond jres = ser.Deserialize<jsonrespond>(jsonstring);
            return jres;
        }
    }
}
