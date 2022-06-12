using RecodedMusicPlayer.Models;
using RecodedMusicPlayer.Models.Soundcloud;
using RecodedMusicPlayer.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RecodedMusicPlayer.Commands.DownloadPageCommands
{
    internal class DownloadMusicCommand : CommandBase
    {

        private DownloaderViewModel _downloaderViewModel;
        private MusicPlayer _musicplayer;

        private string path { get; set; }
        private SoundCloudFile song { get; set; }

        public DownloadMusicCommand(DownloaderViewModel downloaderViewModel)
        {
            _downloaderViewModel = downloaderViewModel;
            _musicplayer = App._musicplayer;
        }

        public override void Execute(object parameter)
        {
            song = ((SoundCloudFile)parameter);

            BackgroundWorker worker = new BackgroundWorker();

            worker.DoWork += Download;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;

            worker.RunWorkerAsync();
        }

        void Download(object sender, DoWorkEventArgs e)
        {
            path = Soudcloud.DownloadMusic(song);
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int index = _musicplayer.GetMusicList().LastOrDefault().index;
            App._musicplayer.AddMusicToLibrary(new MusicFile(path, index + 1));
        }
    }

}
