using Newtonsoft.Json;
using RecodedMusicPlayer.Models.Soundcloud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using RecodedMusicPlayer.JsonModels;
using RecodedMusicPlayer.JsonModels.QuickType;
using System.Diagnostics;
using System.Windows;
using System.Threading;

namespace RecodedMusicPlayer.Models
{
    public class Soudcloud
    {
        private static readonly Dictionary<string, string> Headers = new Dictionary<string, string>()
        {
                { "User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:101.0) Gecko/20100101 Firefox/101.0"},
                { "Accept", "application/json, text/javascript, */*; q=0.01" },
                { "Accept-Language", "en-US,en;q=0.5" },
                { "Accept-Encoding", "application/json" },
                { "Referer", "https://soundcloud.com/" },
                { "Origin", "https://soundcloud.com" },
                { "DNT", "1" },
                { "Connection", "keep-alive" },
                { "Sec-Fetch-Dest", "empty" },
                { "Sec-Fetch-Mode", "cors" },
                { "Sec-Fetch-Site", "same-site" }
        };

        public static async Task<List<SoundCloudFile>> SearchMusic(string query)
        {
            bool AddToList = false;

            while (true)
            {
                try
                {
                    var httpClient = new HttpClient();
                    List<SoundCloudFile> songs = new List<SoundCloudFile>();

                    var request = new HttpRequestMessage(new HttpMethod("GET"), "https://api-v2.soundcloud.com/search?q=" + query + "&variant_ids=&facet=model&user_id=123232-435003-783105-625153&client_id=cyfcuTc4OKTJ09j8IoqWUZQkZ7QFN3p8&limit=20&offset=0&linked_partitioning=1&app_version=1654762087&app_locale=en");

                    foreach (var header in Headers)
                        request.Headers.TryAddWithoutValidation(header.Key, header.Value);

                    var response = await httpClient.SendAsync(request);

                    var data = JsonConvert.DeserializeObject<SoundCloudSearchModel>(await response.Content.ReadAsStringAsync());


                    foreach (var track in data.Collection)
                    {

                        foreach (var item in new dynamic[] { track.Title, track.FullDuration, track.PermalinkUrl, track.ArtworkUrl })
                        {
                            if (item != null)
                            {
                                AddToList = true;
                            }
                            else AddToList = false; break;
                        }

                        if (AddToList)
                        {

                            TimeSpan duration = TimeSpan.FromMilliseconds((int)track.FullDuration);
                            
                            songs.Add(new SoundCloudFile
                            {
                                title = track.Title,
                                duration = duration,
                                permalink = track.PermalinkUrl,
                                cover = track.ArtworkUrl,
                                durationString = string.Format("{0}:{1:00}",
                                    (int)duration.TotalMinutes, duration.Seconds)
                            });
                        }
                        AddToList = false;
                    }

                    return songs;
                    
                } catch (Exception) { continue; }
            }
        }

        public static string DownloadMusic(SoundCloudFile song)
        {
            Process p = new Process();

            string path = String.Format(@"C:\Users\{0}\Music\{1}.mp3", Environment.UserName, song.title);

            p.StartInfo = new ProcessStartInfo("youtube-dl.exe", song.permalink.ToString() + " --embed-thumbnail --add-metadata --postprocessor-args \"-metadata artist=Soundcloud\" -o "+ path);
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.Start();

            p.WaitForExit();

            return path;
        }
    }
}
