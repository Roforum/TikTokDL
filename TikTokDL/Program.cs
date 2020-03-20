using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;
using Colorful;
using static TikTokDL.Helpers.Json;
using System.Net;
using System.ComponentModel;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace TikTokDL
{
    class Program
    {
        public static WebClient client = new WebClient();
        static Formatter[] line1 = new Formatter[]
        {
            new Formatter("TikTok Downloader v1.0", Color.SkyBlue),
            new Formatter("Slay", Color.Pink),
        };
        static Formatter[] options = new Formatter[]
        {
            new Formatter("[0]", Color.Wheat),
            new Formatter("[1]", Color.Wheat),
        };

        static void Main(string[] args) => StartBot();

        static void StartBot()
        {
            Console.Title = "TikTok Downloader - Dev By Slay";
            Console.WriteLineFormatted("{0} | Developed By {1}", Color.Wheat, line1);
            Console.WriteLine("Select An Option To Get Started\n\n", Color.SkyBlue);
            Console.WriteLineFormatted("{0} Download Media From User\n{1} Download Audio From Post\n", Color.White, options);
            string input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    DownloadMedia();
                    break;
                case "1":
                    DownloadAudio();
                    break;
            }
        }
        static void DownloadMedia()
        {
            Console.Clear();
            Console.WriteLine("Enter Post URL:", Color.SkyBlue);
            string url = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Pulling Data...\n", Color.CadetBlue);
            PullJSON(url);
            Formatter[] VideoInfo = new Formatter[]
            {
                new Formatter("Video Data: ", Color.SkyBlue),
                new Formatter(" Size:", Color.Wheat),
                new Formatter(tko.props.pageProps.videoData.itemInfos.video.videoMeta.width, Color.Red),
                new Formatter(tko.props.pageProps.videoData.itemInfos.video.videoMeta.width, Color.Red),
                new Formatter(" Duration:", Color.Wheat),
                new Formatter(tko.props.pageProps.videoData.itemInfos.video.videoMeta.duration, Color.Red),
            };
            Console.WriteLineFormatted("{0}\n {1} {2} x {3}\n {4} {5} seconds", Color.White, VideoInfo);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            client.DownloadFileAsync(new Uri(tko.props.pageProps.videoData.itemInfos.video.urls[0]), "Videos//" + tko.props.pageProps.videoData.itemInfos.id + ".mp4");
            Console.ReadLine();
        }
        
        static void DownloadAudio()
        {
            Console.Clear();
            Console.WriteLine("Enter Post URL:", Color.SkyBlue);
            string url = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Pulling Data...", Color.CadetBlue);
            PullJSON(url);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            client.DownloadFile(tko.props.pageProps.musicInfo.music.coverThumb, "Audio//" + tko.props.pageProps.musicData.musicName + " - " + tko.props.pageProps.musicData.musicName + ".jpeg");
            client.DownloadFileAsync(new Uri(tko.props.pageProps.musicInfo.music.playUrl), "Audio//" + tko.props.pageProps.musicData.musicName + " - " + tko.props.pageProps.musicData.musicName + ".mp3");
            Console.ReadLine();
        }

        private static void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e) => Console.WriteLine("Download Completed!", Color.SkyBlue);
        
    }
}
