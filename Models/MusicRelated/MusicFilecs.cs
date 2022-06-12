using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace RecodedMusicPlayer.Models
{
    public class MusicFile
    {
        //need to convert your fields into properties because of the mainpage listview source: https://stackoverflow.com/a/36112443/11996332
        //took me 30 minutes to figure out ._.

        public int index { get; set; }
        public string filePath { get; set; }
        public string title { get; set; }
        public BitmapImage cover { get; set; }
        public string[] artists { get; set; }
        public string artistsJoined { get; set; }
        public TimeSpan duration { get; set; }
        public double durationTotalSeconds { get; set; }
        public string durationString { get; set; }

        public MusicFile(string file, int index)
        {
            TagLib.File audio = TagLib.File.Create(file);

            //Source: https://stackoverflow.com/questions/6588974/get-imagesource-from-memorystream-in-c-sharp-wpf

            if (audio.Tag.Pictures.Length >= 1)
            {
                MemoryStream memoryStream = new MemoryStream(audio.Tag.Pictures[0].Data.Data);

                var imageSource = new BitmapImage();
                imageSource.BeginInit();
                imageSource.StreamSource = memoryStream;
                imageSource.EndInit();

                this.cover = imageSource;
            }

            this.index = index;
            this.filePath = file;
            this.title = audio.Tag.Title;
            this.artists = audio.Tag.Performers;
            this.duration = audio.Properties.Duration;
            this.artistsJoined = String.Join(", ", audio.Tag.Performers);
            this.durationTotalSeconds = audio.Properties.Duration.TotalSeconds;
            this.durationString = string.Format("{0}:{1:00}",
                    (int)audio.Properties.Duration.TotalMinutes, audio.Properties.Duration.Seconds);
        }
    }
}
