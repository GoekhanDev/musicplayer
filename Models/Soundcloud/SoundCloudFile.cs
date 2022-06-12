using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace RecodedMusicPlayer.Models.Soundcloud
{
    
    public class SoundCloudFile
    {
        public string title { get; set; }
        public TimeSpan duration { get; set; }
        public Uri permalink { get; set; }
        public Uri cover { get; set; }
        public string artistsJoined { get; set; } = "Soundcloud";
        public string durationString { get; set; } 
        public SoundCloudFile() { }
        public SoundCloudFile(string title, TimeSpan duration, Uri permalink, Uri cover, string durationString)
        {
            this.title=title;
            this.duration=duration;
            this.permalink=permalink;
            this.cover=cover;
            this.durationString=durationString;
        }
        public override string ToString() => String.Format("\n\nTitle: {0}\nDuration: {1}\nPermalink: {2}\nCover: {3}", 
            title, duration, permalink, cover);
    }
}
