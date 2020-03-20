using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTokDL.Helpers
{
    public static class Json
    {
        public static TikTokObj tko;
        public static void PullJSON(string url)
        {
            try
            {
                string removeURL = "";
                if (url.Contains("@"))
                {
                    removeURL = "@" + url.Split('@')[1];
                }
                else
                {
                    removeURL = "music" + url.Split(new string[] { "music" }, StringSplitOptions.None)[1];
                }

                var client = new RestClient("http://tiktok.com/");
                client.UserAgent = "Mozilla/5.0 (Linux; Android 6.0; Nexus 5 Build/MRA58N) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.132 Mobile Safari/537.36";
                var request = new RestRequest($"{removeURL}")
                    .AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9")
                    .AddHeader("Accept-Encoding", "gzip, deflate, br")
                    .AddHeader("Accept-Language", "en-US,en;q=0.9");
                var response = client.Get(request);
                string format = "{\"props" + response.Content.Split(new string[] { "props" }, StringSplitOptions.None)[1].Split(new string[] { ",\"pathname" }, StringSplitOptions.None)[0].Replace("$", "_") + "}}";
                tko = JsonConvert.DeserializeObject<TikTokObj>(format);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occured: {ex.Message}");
            }
        }
    }
}
